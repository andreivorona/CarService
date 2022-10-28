namespace CarService.Data.Models
{
    using CarService.Data.Common.Models;

    public class Cars : BaseDeletableModel<int>
    {
        public string Model { get; set; }

        public string Year { get; set; }

        public string Color { get; set; }

        public int? Distance { get; set; }

        public string Car { get; set; }

        public string CarNotes { get; set; }

        public string EngineSpec { get; set; }

        public string WorkDone { get; set; }

        public string ChangedParts { get; set; }

        public string Comment { get; set; }

        public byte[] Picture { get; set; }

        // connection with user table
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
