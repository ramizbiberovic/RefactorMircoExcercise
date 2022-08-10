using NSubstitute;
using Xunit;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class AlarmTest
    {
        private readonly ISensor _sensor = Substitute.For<ISensor>();
        
        [Fact]
        public void AlarmReturns_False_By_Default()
        {
            //Act
            var anAlarm = new Alarm();

            //Assert
            Assert.False(anAlarm.AlarmOn);
        }
    
        [Fact]
        public void AlarmReturns_True_For_16()
        {
            //Arrange
            const double sensorValue = 16;
            _sensor.PopNextPressurePsiValue().Returns(sensorValue);
            
            //Act
            var pressureThresholdConfig = new PressureThresholdConfig();
            var anAlarm = new Alarm(_sensor, pressureThresholdConfig);
            anAlarm.Check();
            
            //Assert
            Assert.True(anAlarm.AlarmOn);
        }
    
        [Fact]
        public void AlarmReturns_False_For_17()
        {
            //Arrange
            const double sensorValue = 17;
            _sensor.PopNextPressurePsiValue().Returns(sensorValue);
            
            //Act
            var pressureThresholdConfig = new PressureThresholdConfig();
            var anAlarm = new Alarm(_sensor, pressureThresholdConfig);
            anAlarm.Check();
            
            //Assert
            Assert.False(anAlarm.AlarmOn);
        }
    
        [Fact]
        public void AlarmReturns_False_For_18()
        {
            //Arrange
            const double sensorValue = 18;
            _sensor.PopNextPressurePsiValue().Returns(sensorValue);
            
            //Act
            var pressureThresholdConfig = new PressureThresholdConfig();
            var anAlarm = new Alarm(_sensor, pressureThresholdConfig);
            anAlarm.Check();
            
            //Assert
            Assert.False(anAlarm.AlarmOn);
        }
    
        [Fact]
        public void AlarmReturns_False_for_21()
        {
            //Arrange
            const double sensorValue = 21;
            _sensor.PopNextPressurePsiValue().Returns(sensorValue);
            
            //Act
            var pressureThresholdConfig = new PressureThresholdConfig();
            var anAlarm = new Alarm(_sensor, pressureThresholdConfig);
            anAlarm.Check();
            
            //Assert
            Assert.False(anAlarm.AlarmOn);
        }
    
        [Fact]
        public void AlarmReturns_True_for_21_01()
        {
            //Arrange
            const double sensorValue = 21.01;
            _sensor.PopNextPressurePsiValue().Returns(sensorValue);
            
            //Act
            var pressureThresholdConfig = new PressureThresholdConfig();
            var anAlarm = new Alarm(_sensor, pressureThresholdConfig);
            anAlarm.Check();
            
            //Assert
            Assert.True(anAlarm.AlarmOn);
        }
    
        [Fact]
        public void AlarmReturns_True_for_22()
        {
            //Arrange
            const double sensorValue = 22;
            _sensor.PopNextPressurePsiValue().Returns(sensorValue);
            
            //Act
            var pressureThresholdConfig = new PressureThresholdConfig();
            var anAlarm = new Alarm(_sensor, pressureThresholdConfig);
            anAlarm.Check();
            
            //Assert
            Assert.True(anAlarm.AlarmOn);
        }
    }
}