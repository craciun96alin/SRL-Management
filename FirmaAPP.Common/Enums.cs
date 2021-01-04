using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.Common
{
    public class Enums
    {
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public enum Color
        {
            Alta = 0,
            Alb = 1,
            Negru = 2,
            Roșu = 3,
            Albastru_deschis = 4,
            Albastru = 5,
            Albastru_regal = 6,
            Verde = 7,
            Galben = 8,
            Gri = 9,
            Portocaliu = 10
        }

        public enum Sex
        {
            Alta = 0,
            M = 1,
            F = 2,
            Unisex = 3,
        }

        public enum TshirtSize
        {
            Alta = 0,
            XS = 1,
            S = 2,
            M = 3,
            L = 4,
            XL = 5,
            XXL = 6,
            XXXL = 7,
            XXXXL = 8,
            XXXXXL = 9,
            Copii_4ani = 10,
            Copii_6ani = 11,
            Copii_8ani = 12,
            Copii_10ani = 13,
            Copii_12ani = 14
        }

        public enum OrderStatus
        {
            Void = 0, 
            [Description ("Trebuie plasată")] 
            Trebuie_plasată = 1, //red
            Plasată = 2, //yellow
            În_lucru = 3, // blue
            Finalizată = 4, //green
            În_asteptare = 5, // lightyellow
        }
        public enum TshirtType
        {
            Altul = 0,
            Basic = 1,
            Basic_free = 2,
            Classic = 3,
            Classic_new = 4,
            Fantasy = 5,
            Viper = 6,
            Viper_free = 7,
            Destiny = 8,
            Slim_fit_Vneck = 9,
            Pique_polo = 10,
            Single_J = 11,
            Urban = 12,
            Cotton_Heavy =13,
            Cotton = 14,
            Collar_up = 15,
            Joy = 16,
            Perfection_plain = 17
        }
        public enum FilamentType
        {
            Altul = 0,
            PLA = 1,
            PETG =2,
            TPU_Flex =3,
            ABS = 4
        }

        public enum VinylType
        {
            Altul = 0,
            Normal = 1,
            Flock = 2,
            Glitter = 3
        }

        public enum Rating
        {
            Nedefinit = 0,
            Foarte_slab = 1,
            Slab = 2,
            Mediu = 3,
            Bun = 4,
            Foarte_bun = 5
        }

        public enum OrderType
        {
            Nedefinit = 0,
            Achiziție = 1,
            Vândut_tricou = 2,
            Vândut_3D = 3
        }

        public enum BillStatus
        {
            Void = 0, //blue
            Fără_factură = 1,  //red
            Neemisă = 2, // yellow
            Emisă = 3, // orange
            Finalizată = 4 //green
        }

        public enum DesignStatus
        {
            Void = 0, //blue
            Plănuit = 1, //Orange
            În_lucru = 2, //Yellow
            În_așteptare = 3, //Light Yellow
            Finlizată = 4 //Green
        }

        public enum _3DPrintQuality
        {
            UltraDetail_005 = 0,
            UltraDetail_007 = 1,
            Detail_010 = 2,
            Quality_015 = 3,
            Speed_015 = 4,
            Quality_020 = 5,
            Speed_020 = 6,
            Draft_030 = 7
        }

        public enum MoneyFrom
        {
            Extra = 0,
            Digital = 1,
            Cash = 2
        }

        public enum UserRole
        {
            Admin = 0,
            Normal = 1
        }
    }
}
