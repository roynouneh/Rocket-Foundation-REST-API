using System;
using System.Collections.Generic;

namespace Rocket_Elevators_REST_API.Models
{
    public class Intervention
    {
        public long id { get; set; }
        public int author { get; set; }
        public int building_id { get; set; }
        public int? battery_id { get; set; }
        public int? column_id { get; set; }
        public int? elevator_id { get; set; }
        public int? employee_id { get; set; }
        public DateTime? start_date_and_time_of_the_intervention { get; set; }
        public DateTime? end_date_and_time_of_the_intervention { get; set; }
        public string? result { get; set; }
        public string report { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}