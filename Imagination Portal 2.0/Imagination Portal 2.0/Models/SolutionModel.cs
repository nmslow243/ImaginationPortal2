using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Imagination_Portal_2._0.Models
{
    public class CreateFinal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string Tags { get; set; }

        public int? IssueId { get; set; }

        public virtual Issue Issue { get; set; }


    }
    public class CreateStep1
    {
        public int Id { get; set; }

        [DataType(DataType.MultilineText)]
        public string Feelings { get; set; }

        [DataType(DataType.MultilineText)]
        public string Achieve { get; set; }

        [DataType(DataType.MultilineText)]
        public string RootCauses { get; set; }

        [DataType(DataType.MultilineText)]
        public string Elements { get; set; }

        [DataType(DataType.MultilineText)]
        public string Analogy { get; set; }

    }

    public class CreateStep2
    {
        public int Id { get; set; }

        [DataType(DataType.MultilineText)]
        public string Combine { get; set; }

        [DataType(DataType.MultilineText)]
        public string Substitution { get; set; }

        [DataType(DataType.MultilineText)]
        public string MagnifyMinimize { get; set; }

        [DataType(DataType.MultilineText)]
        public string Adapt { get; set; }

        [DataType(DataType.MultilineText)]
        public string OtherUse { get; set; }

        [DataType(DataType.MultilineText)]
        public string Eliminate { get; set; }

        [DataType(DataType.MultilineText)]
        public string Rearrange { get; set; }

        [DataType(DataType.MultilineText)]
        public string Reverse { get; set; }

        [DataType(DataType.MultilineText)]
        public string Opposite { get; set; }

    }

    public class CreateStep3
    {
        public int Id { get; set; }

        [DataType(DataType.MultilineText)]
        public string VisualizeNevers { get; set; }

        [DataType(DataType.MultilineText)]
        public string EvaluateIdeas { get; set; }

        [DataType(DataType.MultilineText)]
        public string Vital { get; set; }

        [DataType(DataType.MultilineText)]
        public string Fatal { get; set; }

    }

    public class Solution
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string Tags { get; set; }

        //First page of steps
        [DataType(DataType.MultilineText)]
        public string Feelings { get; set; }

        [DataType(DataType.MultilineText)]
        public string Achieve { get; set; }

        [DataType(DataType.MultilineText)]
        public string RootCauses { get; set; }

        [DataType(DataType.MultilineText)]
        public string Elements { get; set; }

        [DataType(DataType.MultilineText)]
        public string Analogy { get; set; }

        //Second page of steps
        [DataType(DataType.MultilineText)]
        public string Combine { get; set; }

        [DataType(DataType.MultilineText)]
        public string Substitution { get; set; }

        [DataType(DataType.MultilineText)]
        public string MagnifyMinimize { get; set; }

        [DataType(DataType.MultilineText)]
        public string Adapt { get; set; }

        [DataType(DataType.MultilineText)]
        public string OtherUse { get; set; }

        [DataType(DataType.MultilineText)]
        public string Eliminate { get; set; }

        [DataType(DataType.MultilineText)]
        public string Rearrange { get; set; }

        [DataType(DataType.MultilineText)]
        public string Reverse { get; set; }

        [DataType(DataType.MultilineText)]
        public string Opposite { get; set; }

        //Third page of steps
        public string VisualizeNevers { get; set; }

        [DataType(DataType.MultilineText)]
        public string EvaluateIdeas { get; set; }

        [DataType(DataType.MultilineText)]
        public string Vital { get; set; }

        [DataType(DataType.MultilineText)]
        public string Fatal { get; set; }

        public int? IssueId { get; set; }

        public virtual Issue Issue { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ApplicationUser User { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public Guid userGUID { get; set; }
        
        public int currentStatus { get; set; }
    }
}