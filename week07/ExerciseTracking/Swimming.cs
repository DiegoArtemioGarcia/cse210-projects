namespace GymActivities.Models
{
    public class Swimming : Activity  // Cambiar a public para consistencia
    {
        private readonly int _laps;  // Hacer readonly
        public Swimming(string date, int minutes, int laps)
            : base(date, minutes)
        {
            if (laps <= 0)
                throw new ArgumentException("El número de vueltas debe ser positivo", nameof(laps));
                
            _laps = laps;
        }
        public override double GetDistance() => (_laps * 50) / 1000.0;
        public override double GetSpeed() => (GetDistance() / GetMinutes()) * 60;
        public override double GetPace() => GetMinutes() / GetDistance();
        public override string GetSummary()
        {
            return $"{GetDate()} Swimming ({GetMinutes()} min): Distancia {GetDistance():0.0} km, Velocidad {GetSpeed():0.0} km/h, Ritmo: {GetPace():0.00} min/km";
        }
    }
}