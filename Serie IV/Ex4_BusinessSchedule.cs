using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    public class BusinessSchedule
    {
        /// <summary>
        /// Dictionnaire d'emploie du temps
        /// </summary>
        private SortedDictionary<DateTime, DateTime> _reunion;

        /// <summary>
        /// Date de début du fonctionnement de l'emploi du temps
        /// </summary>
        private DateTime _dateDebut;

        /// <summary>
        /// Date de fin du fonctionnement de l'emploi du temps
        /// </summary>
        private DateTime _dateFin;

        public BusinessSchedule()
        {
            _reunion = new SortedDictionary<DateTime, DateTime>();
            _dateDebut = new DateTime(2020, 01, 01);
            _dateFin = new DateTime(2030, 12, 31);
        }

        public bool IsEmpty()
        {
            if (_reunion.Count == 0)
            {
                return true;
            }
            return false;
        }

        public void SetRangeOfDates(DateTime begin, DateTime end)
        {
            if (IsEmpty() && begin < end)
            {
                _dateDebut = begin;
                _dateFin = end;
            }
            else 
            {
                throw new Exception("Impossible de changer les dates");
            }
        }

        private KeyValuePair<DateTime, DateTime> ClosestElements(DateTime beginMeeting)
        {
            DateTime DateMin = DateTime.MinValue;
            DateTime DateMax = DateTime.MaxValue;

            foreach (DateTime daylyMeeting in _reunion.Keys)
            {
                if (beginMeeting >= DateMin)
                {
                    DateMin = daylyMeeting;
                }
                else if (beginMeeting <= DateMax)
                {
                    DateMax = daylyMeeting;
                    break;
                }
            }
            return new KeyValuePair<DateTime, DateTime>(DateMin, DateMax);
        }

        public bool AddBusinessMeeting(DateTime date, TimeSpan duration)
        {
            if (date > _dateDebut && date + duration < _dateFin)
            {
                var closes = ClosestElements(date);
                DateTime finReuPrec = closes.Key == DateTime.MinValue ? closes.Key : _reunion[closes.Key];
                if (finReuPrec <= date && closes.Value >= date + duration)
                {
                    _reunion.Add(date, date + duration);
                    return true;
                }

            }
            return false;
        }

        public bool DeleteBusinessMeeting(DateTime date, TimeSpan duration)
        {
            if (!IsEmpty() && _reunion.ContainsKey(date))
            {
                _reunion.Remove(date);
                return true;
            }
            return false;
        }
    

        public int ClearMeetingPeriod(DateTime begin, DateTime end)
        {
            int nbrdel = 0;
            foreach (var meeting in _reunion.Keys)
            {
                // if(ClosestElements(begin))
                if (meeting > begin && meeting < end)
                {
                    _reunion.Remove(meeting);
                    nbrdel++;
                }
            }
            return nbrdel;
        }

        public void DisplayMeetings()
        {
            int increment = 1;
            Console.WriteLine($"Emploi du temps : {_dateDebut} - {_dateFin}");
            Console.WriteLine("-------------------------------------");

            foreach (var item in _reunion)
            {
                Console.WriteLine($"Reunion{increment.ToString().PadRight(7)} : {item.Key} - {item.Value}");
                increment += 1;
            }

            if (IsEmpty())
            {
                Console.WriteLine("Pas de réunion programmées");
            }

        }
    }
}
