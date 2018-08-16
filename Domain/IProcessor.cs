﻿using System.Threading.Tasks;

namespace Domain
{
    public interface IProcessor<T> where T : class
    {
        Task<T> CheckInput();
        void SetTolerance(int tolerance);
        void SetAccuracy(int accuracy);
    }
}