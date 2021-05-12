using System;

namespace Chapter6_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();

            ILight livingRoomLight = new Light();
            ILight kitchenLight = new Light();
            IStereo stereo = new Stereo();
            IFan fan = new CeilingFan("Living room");

            ICommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            ICommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            ICommand kitcherRoomLightOn = new LightOnCommand(kitchenLight);
            ICommand kitcherRoomLightOff = new LightOffCommand(kitchenLight);
            ICommand stereoOnWithCDCommand = new StereoOnWithCDCommand(stereo);
            ICommand stereoOffWithCDCommand = new StereoOffWithCDCommand(stereo);
            ICommand fanHighCommand = new CeilingFanHighCommand(fan);
            ICommand fanMediumCommand = new CeilingFanMediumCommand(fan);
            ICommand fanLowCommand = new CeilingFanLowCommand(fan);
            ICommand fanOffCommand = new CeilingFanOffCommand(fan);
            ICommand macroOnCommand = new MacroCommand(new ICommand[] { fanHighCommand, livingRoomLightOn});
            ICommand macroOffCommand = new MacroCommand(new ICommand[] { fanLowCommand, livingRoomLightOff });

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitcherRoomLightOn, kitcherRoomLightOff);
            remote.SetCommand(2, stereoOnWithCDCommand, stereoOffWithCDCommand);
            remote.SetCommand(3, fanHighCommand, fanOffCommand);
            remote.SetCommand(4, fanMediumCommand, fanOffCommand);
            remote.SetCommand(5, fanLowCommand, fanOffCommand);
            remote.SetCommand(6, macroOnCommand, macroOffCommand);
            Console.WriteLine(remote);

            remote.PressOn(0);
            remote.PressOff(0);
            remote.PressUndo();
            remote.PressOn(1);
            remote.PressOff(1);
            remote.PressUndo();
            remote.PressOn(2);
            remote.PressOff(2);
            remote.PressUndo();
            remote.PressOn(3);
            remote.PressOff(3);
            remote.PressUndo();
            remote.PressOn(4);
            remote.PressOff(4);
            remote.PressUndo();
            remote.PressOn(5);
            remote.PressOff(5);
            remote.PressUndo();
            remote.PressOn(6);
            remote.PressOff(6);
            remote.PressUndo();

            Console.ReadKey();
        }
    }
}
