using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    public class BusinessSchedule
    
    {

        private DateTime _end;
        private SortedDictionary<DateTime, TimeSpan> _calendar;
        private DateTime _beginning;
        public BusinessSchedule()
        {
            _beginning = new DateTime(2020,1,1);
            _end = new DateTime(2030, 12, 31);
            _calendar = new SortedDictionary<DateTime, TimeSpan>();
        }


        public bool IsEmpty()
        {
            if (_calendar.Count == 0)
            {
                return true;
            }
            return false;
        }

        public void SetRangeOfDates(DateTime begin, DateTime end)
        {
            if (!IsEmpty())
            {
                throw new Exception("Emploi du temps rempli");
            }
            
            if (_beginning >= _end)
            {
                throw new Exception("Dates invalides");
            }
            
        }

        private KeyValuePair<DateTime, DateTime> ClosestElements(DateTime beginMeeting)
        {
            DateTime datemin = DateTime.MinValue;
            DateTime datemax = DateTime.MaxValue;

            foreach (DateTime meeting in _calendar.Keys)
            {
                if (beginMeeting >= meeting)
                {
                    datemin = meeting;
                }
                else if (beginMeeting <= meeting)
                {
                    datemax = meeting;
                    break;
                }
            }
            return new KeyValuePair<DateTime, DateTime>(datemin,datemax);
        }

        public bool AddBusinessMeeting(DateTime date, TimeSpan duration)
        {
            if (date >= _beginning && date + duration <= _end)
            {
                KeyValuePair<DateTime, DateTime> closestElements = ClosestElements(date);
                DateTime lowerDt = closestElements.Key;
                DateTime upperDt = closestElements.Value;

                if ((lowerDt == DateTime.MinValue || date >= lowerDt + _calendar[lowerDt]) && 
                    (upperDt == DateTime.MaxValue || date + duration <= upperDt ))
                {
                    _calendar.Add(date, duration);
                    return true;
                }
            }
            return false;
        }

        public bool DeleteBusinessMeeting(DateTime date, TimeSpan duration)
        {
            if (!IsEmpty() && _calendar.ContainsKey(date) && _calendar[date] == duration )
            {
                return _calendar.Remove(date);
            }
            return false;
        }

        public int ClearMeetingPeriod(DateTime begin, DateTime end)
        {
            //TODO

            int meetingsDeleted = 0;

            foreach (var meeting in _calendar.Keys)
            {
                if (meeting > begin && meeting < end)
                {
                    _calendar.Remove(meeting);
                    meetingsDeleted++;
                }
            }


            return meetingsDeleted;
        }

        public void DisplayMeetings()
        {
            int i = 0;
            Console.WriteLine($"Emploi du temps : {_beginning} - {_end }");
            Console.WriteLine("-------------------------------------------------");
            if (IsEmpty())
            {
                Console.WriteLine("Pas de réunions à venir pour cette période");
            }
            else
            {
                foreach (var reunion in _calendar)
                {
                    i++;
                    Console.WriteLine($"Réunion {i}     : {reunion.Key} - {reunion.Value}");
                }
            }
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
