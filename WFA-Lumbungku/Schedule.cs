using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Lumbungku
{
    internal class Schedule
    {
        public int ScheduleId { get; set; }
        public string Activity { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; }

        // Metode untuk menambahkan jadwal
        public static void AddSchedule()
        {
            throw new NotImplementedException();
        }

        //Metode untuk menampilkan semua jadwal
        public static List<Schedule> GetAllSchedules(List<Schedule> schedules)
        {
            throw new NotImplementedException();
        }

        //Metode untuk mengupdate jadwal
        public static void UpdateSchedule(List<Schedule> schedules, int scheduleId, Schedule updatedSchedule)
        {
            throw new NotImplementedException();
        }

        //Metode untuk menghapus jadwal
        public static void DeleteSchedule(List<Schedule> schedules, int scheduleId)
        {
            throw new NotImplementedException();
        }

        //Metode untuk menampilkan jadwal dari range waktu tertentu
        public static List<Schedule> GetSchedulesInRange(List<Schedule> schedules, DateTime fromDate, DateTime toDate)
        {
            throw new NotImplementedException();
        }

    }
}

