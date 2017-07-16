using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advanced_Combat_Tracker;
using System.Windows.Forms;
using System.Xml.Xsl;
using System.IO;
using System.Xml;
// reference:System.dll

namespace Discord
{
    public class DiscordPlugin : IActPluginV1
    {
        public void DeInitPlugin()
        {
            throw new NotImplementedException();
        }

        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            throw new NotImplementedException();
        }



        delegate void ControlSetTextCallback(Form parent, Control target, string text);
        public static void ControlSetText(Form parent, Control target, string text)
        {
            if (target.InvokeRequired)
            {
                ControlSetTextCallback d = new ControlSetTextCallback(ControlSetText);
                parent.Invoke(d, new object[] { parent, target, text });
            }
            else
            {
                target.Text = text;
            }
        }
    }
}
