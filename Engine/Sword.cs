﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Sword
    {

        public string SwordName { get; set; }
        public int SwordID { get; set; }
        public int BaseSwordDamage { get; set; } //wood = 1, bronze = 10, etc
        public int MaxSwordDamage { get; set; }  //wood = 5, wood+5 = 10, bronze = 5, bent+5 = 10, etc.

               

        public void AssignSwordStats(int ID)
        {
            SwordID = ID;
            switch (ID)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    BaseSwordDamage = 1;
                    SwordName = "Wooden Sword";
                    MaxSwordDamage = BaseSwordDamage + SwordID;
                    if (SwordID != 0)
                        SwordName += "+" + SwordID.ToString();
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                    BaseSwordDamage = 10;
                    SwordName = "Bronze Sword";
                    MaxSwordDamage = BaseSwordDamage + (SwordID - 1);
                    SwordName += "+" + (SwordID - 1).ToString();
                    break;
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                    BaseSwordDamage = 20;
                    SwordName = "Iron Sword";
                    MaxSwordDamage = BaseSwordDamage + (SwordID - 7);
                    SwordName += "+" + (SwordID - 7).ToString();
                    break;
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                    BaseSwordDamage = 30;
                    SwordName = "Steel Sword";
                    MaxSwordDamage = BaseSwordDamage + (SwordID - 13);
                    SwordName += "+" + (SwordID - 13).ToString();
                    break;
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                    BaseSwordDamage = 40;
                    SwordName = "Silver Sword";
                    MaxSwordDamage = BaseSwordDamage + (SwordID - 19);
                    SwordName += "+" + (SwordID - 19).ToString();
                    break;
                case 1337:
                    BaseSwordDamage = 999;
                    MaxSwordDamage = 1000;
                    SwordName = "Go to Help Night";
                    break;
                default:
                    SwordName = "Error";
                    break;
            }

        }

    }
}