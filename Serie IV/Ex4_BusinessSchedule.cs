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
            KeyValuePair<DateTime, DateTime> abc = new KeyValuePair<DateTime, DateTime>();
            if (IsEmpty())
            {
                return new KeyValuePair<DateTime, DateTime>();
            }
            else if (_calendar.Count == 1)
            {
                foreach (var meeting in _calendar)
                {

                }


                if (_calendar. > beginMeeting)
                {
                    abc = (new KeyValuePair<DateTime, DateTime>(beginMeeting, DateTime.MinValue));
                    return abc;
                }
                abc = (new KeyValuePair<DateTime, DateTime>(DateTime.MinValue, beginMeeting));
                return abc;
            }
            else
            {
                DateTime before;
                DateTime after;
                foreach (var meeting in _calendar)
                {
                    if (meeting.Key > beginMeeting)
                    {
                        before = beginMeeting;
                    }
                    else
                    {
                        after = beginMeeting;
                        abc = (new KeyValuePair<DateTime, DateTime>());
                    }
                }
            }
            return new KeyValuePair<DateTime, DateTime>();
        }

        public bool AddBusinessMeeting(DateTime date, TimeSpan duration)
        {
            //TODO
            return false;
        }

        public bool DeleteBusinessMeeting(DateTime date, TimeSpan duration)
        {
            //TODO
            return false;
        }

        public int ClearMeetingPeriod(DateTime begin, DateTime end)
        {
            //TODO
            return -1;
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
