namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrainingAnswer")]
    public partial class TrainingAnswer
    {
        public Guid Id { get; set; }

        public Guid? QuestionId { get; set; }

        public string Answer { get; set; }

        public Guid? TrainingId { get; set; }
    }
}
