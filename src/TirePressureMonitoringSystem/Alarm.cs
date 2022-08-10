namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private readonly ISensor _sensor;
        private readonly PressureThresholdConfig _pressureThresholdConfig;

        public Alarm()
        {
            _sensor = new Sensor();
            _pressureThresholdConfig = new PressureThresholdConfig();
        }
        
        public Alarm(ISensor sensor, PressureThresholdConfig pressureThresholdConfig)
        {
            _sensor = sensor;
            _pressureThresholdConfig = pressureThresholdConfig;
        }
        
        public void Check()
        {
            var psiPressureValue = _sensor.PopNextPressurePsiValue();

            if (psiPressureValue < _pressureThresholdConfig.LowPressureThreshold || _pressureThresholdConfig.HighPressureThreshold < psiPressureValue)
            {
                AlarmOn = true;
            }
        }

        public bool AlarmOn { get; private set; }
    }
}
