using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OPM.Models
{
    public class AddKiddoViewModel
    {
        [Required (ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage ="A Username is required")]
        public string UserName { get; set; }

        public int ParentId { get; set; }

        public List<SelectListItem> Parent { get; set; }

        public AddKiddoViewModel(List<ParentUser> parents)
        {
            Parent = new List<SelectListItem>();

            foreach(var parent in parents)
            {
                Parent.Add(
                    new SelectListItem
                    {
                        Value = parent.Id.ToString(),
                        Text = parent.UserName
                    });
            }
        }

        public AddKiddoViewModel()
        { }

    }
}
