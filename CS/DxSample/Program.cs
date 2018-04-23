using System;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System.IO;

namespace DxSample {
    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableFormSkins();
            InMemoryDataStore provider = new InMemoryDataStore();
            if (File.Exists("data.xml"))
                provider.ReadXml("data.xml");
            XpoDefault.DataLayer = new SimpleDataLayer(provider);
            Application.Run(new MainForm());
            provider.WriteXml("data.xml");
        }
    }
}
