namespace CarFactory
{
    /// <summary>
    /// Concrete Creator.
    /// </summary>
    class Mini : Creator
    {
        public override void CreateCars()
        {
            this.Parts.Add(new Tyres { });
            this.Parts.Add(new Engine { });
        }
    }
}
