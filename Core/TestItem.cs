using PetaPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollection.Core
{
    [PrimaryKey("ItemId", AutoIncrement = true)]
    public class TestItem
    {
        public int? ItemId { get; set; }
        /// <summary>
        /// 题型
        /// </summary>
        public TestItemType? ItemType { get; set; }
        public string ItemContent { get; set; }
        /// <summary>
        /// 学科
        /// </summary>
        public string Course { get; set; }
        /// <summary>
        /// 年级
        /// </summary>
        public GradeEnum? Grade { get; set; }
        public string Tags { get; set; }
        /// <summary>
        /// 学期
        /// </summary>
        public SemesterEnum? Semester { get; set; }
    }

    public enum TestItemType
    {
        [Display(Name = "选择题")]
        Choose = 1,
        [Display(Name = "填空题")]
        Fill,
        [Display(Name = "问答题")]
        QAndA,
        [Display(Name = "判断题")]
        TrueFalse
    }

    public enum GradeEnum
    {
        [Display(Name = "一年级")]
        One = 1,
        [Display(Name = "二年级")]
        Two,
        [Display(Name = "三年级")]
        Three,
        [Display(Name = "四年级")]
        Four,
        [Display(Name = "五年级")]
        Five,
        [Display(Name = "六年级")]
        Six,
    }

    public enum SemesterEnum
    {
        [Display(Name = "上学期")]
        First = 1,
        [Display(Name = "下学期")]
        Second
    }
}
