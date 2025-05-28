    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Shared.Lib.Models
    {
        public class SharedData
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;

            private DateTime CreatedAt { get; set; } = DateTime.UtcNow;
                
            public string GetInfo()
        {
            return $"Id: ${Id}, Name: ${Name}, CreatedAt: ${CreatedAt}";
        }      
                        
        }
    }
