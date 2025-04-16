namespace GymActivities.Models
{
    public class Running : Activity
    {
        private readonly double _distance;
        public Running(string date, int minutes, double distance)
            : base(date, minutes)
        {
            if (distance <= 0)
                throw new ArgumentException("La distancia debe ser positiva", nameof(distance));
            
            _distance = distance;
        }
        public override double GetDistance() => _distance;
        
        public override double GetSpeed() 
        {
            if (GetMinutes() <= 0) return 0;
            return (_distance / GetMinutes()) * 60;
        }
        
        public override double GetPace() 
        {
            if (_distance <= 0) return 0;
            return GetMinutes() / _distance;
        }
        public override string GetSummary()
        {
            return $"{GetDate()} Running ({GetMinutes()} min): " +
                   $"Distancia {GetDistance():0.0} km, " +
                   $"Velocidad {GetSpeed():0.0} km/h, " +
                   $"Ritmo: {GetPace():0.00} min/km";
        }
    }
}
