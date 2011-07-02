/*
	Copyright 2011 MCForge
		
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.osedu.org/licenses/ECL-2.0
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
using System;

namespace MCForge
{
    public class CmdServerinfo : Command
    {
        public override string name { get { return "serverinfo"; } }
        public override string shortcut { get { return "info"; } }
        public override string type { get { return "information"; } }
        public override bool museumUsable { get { return true; } }
        public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }

        public override void Use(Player p, string message)
        {
            if (message != "") { Help(p); return; }
            Player.SendMessage(p, "&bThis server is: &e" + Server.name);
            Player.SendMessage(p, "&bPowered by &eMCForge");
            Command.all.Find("devs").Use(p, "");
            Player.SendMessage(p, "&bCurrency is: " + Server.moneys);
        }

        // This one controls what happens when you use /help [commandname].
        public override void Help(Player p)
        {
            Player.SendMessage(p, "/serverinfo - Shows you information about the Servers Name, etc.");
            Player.SendMessage(p, "                Shortcut  =  si  ");
        }
    }
}

