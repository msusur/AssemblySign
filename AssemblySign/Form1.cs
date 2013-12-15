using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AssemblySign.Properties;
using Mono.Cecil;

namespace AssemblySign
{
    public partial class MainForm : Form
    {
        private AssemblyDefinition _currentAssemblyDefinition;
        private string _currentPath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnBrowseAssemblyFolderClick(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.SelectedPath = _txtFolder.Text;
                var result = dialog.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return;
                }
                _txtFolder.Text = dialog.SelectedPath;
                CheckAssemblies(_txtFolder.Text);
            }
        }

        private void CheckAssemblies(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("text");
            }
            if (!Directory.Exists(text))
            {
                throw new DirectoryNotFoundException(text);
            }
            var assemblies = Directory.GetFiles(text, "*.dll", SearchOption.AllDirectories);
            _assemblies.Items.Clear();
            assemblies.ToList().ForEach(s => _assemblies.Items.Add(new ListViewItem
                                                                   {
                                                                       Text = Path.GetFileName(s),
                                                                       Tag = s
                                                                   }));
        }

        private void AssembliesSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_assemblies.SelectedItems.Count == 0)
            {
                return;
            }
            var item = _assemblies.SelectedItems[0];
            _currentPath = _assemblyPath.Text = item.Tag.ToString();
            _currentAssemblyDefinition = AssemblyDefinition.ReadAssembly(_currentPath);
            var assemblyName = _currentAssemblyDefinition.Name;
            _chkIsSigned.Checked = assemblyName.HasPublicKey;
            _signAssembly.Enabled = !assemblyName.HasPublicKey;

            _assemblyFullName.Text = assemblyName.FullName;
        }

        private void SignAssemblyClick(object sender, EventArgs e)
        {
            if (!File.Exists(_txtKeyFile.Text))
            {
                throw new FileNotFoundException("Key file not found.");
            }
            try
            {
                var snk = new StrongNameKeyPair(File.ReadAllBytes(_txtKeyFile.Text));
                _currentAssemblyDefinition.Name.HasPublicKey = true;
                _currentAssemblyDefinition.Name.PublicKey = snk.PublicKey;
                _currentAssemblyDefinition.Name.HashAlgorithm = AssemblyHashAlgorithm.SHA1;
                _currentAssemblyDefinition.Name.Attributes &= AssemblyAttributes.PublicKey;
                _currentAssemblyDefinition.Write(_currentPath, new WriterParameters { StrongNameKeyPair = snk });
                MessageBox.Show(Resources.MainForm_SignAssemblyClick_Done_);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Signing Failed : {0}", ex.Message), ex);
            }
        }

        private void BtnBrowseKeyFileClick(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "";
                var result = dialog.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return;
                }
                _txtKeyFile.Text = dialog.FileName;
            }
        }
    }
}