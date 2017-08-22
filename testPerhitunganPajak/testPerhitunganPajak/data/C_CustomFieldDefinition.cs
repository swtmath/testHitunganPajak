namespace testPerhitunganPajak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CustomFieldDefinition")]
    public partial class C_CustomFieldDefinition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_CustomFieldDefinition()
        {
            C_CustomField = new HashSet<C_CustomField>();
        }

        public Guid Id { get; set; }

        public Guid? DropDownItemId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Length { get; set; }

        public int? DataType { get; set; }

        public int? SourceType { get; set; }

        public bool? Visible { get; set; }

        public int? LineNumber { get; set; }

        public Guid? ReferenceId { get; set; }

        public bool? ReportFilter { get; set; }

        public int? VisibleReminder { get; set; }

        [StringLength(50)]
        public string CustomFieldGroup { get; set; }

        public int? Mandatory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_CustomField> C_CustomField { get; set; }
    }
}
