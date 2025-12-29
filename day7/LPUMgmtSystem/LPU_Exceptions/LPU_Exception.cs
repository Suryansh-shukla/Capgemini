namespace LPU_Exceptions
{
    /// <summary>
    ///     Custom Exception Class Created for LPU Project
    ///     By Suryansh Shukla on Date 29/12/2025 at 11:34 AM 
    /// </summary>
    public class LPU_Exception : Exception
    {
        public LPU_Exception():base() { }
        public LPU_Exception(string errorMsg):base(errorMsg) 
        {

        }
    }
}
