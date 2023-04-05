﻿namespace DesignPatternASP.DesignPattern.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
