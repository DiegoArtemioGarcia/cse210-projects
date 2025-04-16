namespace GymActivities.Models
{
    public class Cycling : Activity  // 👈 igual, debe ser PUBLIC
    {
        private double _speed;

        public Cycling(string date, int minutes, double speed)
            : base(date, minutes)
        {
            _speed = speed;
        }

        public override double GetDistance() => (_speed * GetMinutes()) / 60;
        public override double GetSpeed() => _speed;
        public override double GetPace() => 60 / _speed;

        public override string GetSummary()
        {
            return $"{GetDate()} Cycling ({GetMinutes()} min): Distancia {GetDistance():0.0} km, Velocidad {GetSpeed():0.0} km/h, Ritmo: {GetPace():0.00} min/km";
        }
    }
}
