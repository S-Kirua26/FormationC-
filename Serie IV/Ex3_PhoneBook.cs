using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Serie_IV
{
    public class PhoneBook
    {
        private Dictionary<string, string> _annuaire;

        public PhoneBook()
        {
            _annuaire = new Dictionary<string, string>();
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            //return phoneNumber.Length != 10 || phoneNumber[0] != '0' || phoneNumber[1] == '0' || !int.TryParse(phoneNumber, out int resultat); autre version
            string firtsNumber = phoneNumber.Substring(0, 1);
            int retour1;
            int.TryParse(firtsNumber, out retour1);

            string lastNumber = phoneNumber.Substring(9, 1);
            int retour2;
            int.TryParse(lastNumber, out retour2);

            if (phoneNumber.Length > 10 || phoneNumber.Length < 10 || retour1 != 0 || retour2 == 0)
            {
                throw new Exception("Numéro de téléphone invalide");
            }

            return true;
        }

        public bool ContainsPhoneContact(string phoneNumber)
        {
            return _annuaire.ContainsKey(phoneNumber);
            //if (IsValidPhoneNumber(phoneNumber))
            //{
            //    Console.WriteLine($"Le numéro {phoneNumber} existe dans l'annuaire");
            //    return _annuaire.ContainsKey(phoneNumber);
            //}
            //else
            //{
            //    return false;
            //    throw new Exception("L'annuaire ne contient pas ce numéro");
            //}
        }

        public void PhoneContact(string phoneNumber)
        {
            if (ContainsPhoneContact(phoneNumber))
            {
                Console.WriteLine($"num téléphone : {phoneNumber} : {_annuaire[phoneNumber]}");
            }
            else
            {
                throw new ArgumentException("Aucun contact associer à ce numéro");
            }

        }

        public bool AddPhoneNumber(string phoneNumber, string name)
        {
            if (IsValidPhoneNumber(phoneNumber) && !ContainsPhoneContact(phoneNumber))
            {
                _annuaire.Add(phoneNumber, name);
                Console.WriteLine("Numéro ajouté à l'annuaire");
            }
            else
            {
                throw new Exception("Impossible d'ajouter le numéro et le contact à l'annuaire");
            }
            return false;

        }

        public bool DeletePhoneNumber(string phoneNumber)
        {
            if (ContainsPhoneContact(phoneNumber))
            {
                _annuaire.Remove(phoneNumber);
                Console.WriteLine("Numéro supprimer de l'annuaire");
            }
            else
            {
                throw new Exception("Impossible de supprimer le numéro et le contact à l'annuaire");
            }
            return false;

        }

        public void DisplayPhoneBook()
        {
            Console.WriteLine("Annuaire téléphonique");

            foreach (var item in _annuaire)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
