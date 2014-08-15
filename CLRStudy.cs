using CLROBS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CLROBS;

namespace CLRStudy
{
    public class CLRStudyPlugn : AbstractPlugin
    {

        public CLRStudyPlugn()
        {
            // Setup the default properties
            Name = "Sample Image Plugin";
            Description = "Sample Image Plugin lets you show a picture";
        }

        public override bool LoadPlugin()
        {
            API.Instance.AddImageSourceFactory(new MyImageSourceFactory());

            API.Instance.AddSettingsPane(new MySetttingPanel());


            return true;
        }

        public override void OnStartStream()
        {
           
        }

    }

    class MyImageSourceFactory : AbstractImageSourceFactory
    {

        public override ImageSource Create(XElement data)
        {
            return null;
        }

        public override bool ShowConfiguration(XElement data)
        {
            return false;
        }
    }

    class MySetttingPanel : AbstractWPFSettingsPane
    {
        public override string Category
        {
            get { return "ニコニコ生放送"; }
        }

        public override void ApplySettings()
        {
            throw new NotImplementedException();
        }

        public override void CancelSettings()
        {
            throw new NotImplementedException();
        }

        public override UIElement CreateUIElement()
        {
            return new NiconicoSettingPanelControl();
        }

        public override bool HasDefaults()
        {
            return false;
        }

        public override void SetDefaults()
        {
            throw new NotImplementedException();
        }
    }
}
