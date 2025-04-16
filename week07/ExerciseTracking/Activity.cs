using System;
namespace GymActivities.Models
{
    public abstract class Activity
    {
        protected readonly string _date;  // Cambiar a readonly ya que no debería modificarse después de constructor
        protected readonly int _minutes;  // Igual aquí
        public Activity(string date, int minutes)
        {
            if (string.IsNullOrWhiteSpace(date))
                throw new ArgumentException("La fecha no puede estar vacía", nameof(date));
            if (minutes <= 0)
                throw new ArgumentException("Los minutos deben ser positivos", nameof(minutes));
            _date = date;
            _minutes = minutes;
        }
        public string GetDate() => _date;
        public int GetMinutes() => _minutes;
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();
        public virtual string GetSummary()
        {
            return $"{_date} Activity ({_minutes} min)";
        }
    }
}