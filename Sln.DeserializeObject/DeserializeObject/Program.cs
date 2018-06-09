﻿using DeserializeObject.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeserializeObject
{
    class Program
    {
        static void Main(string[] args)
        {

            string jsonHoliDay = "{\"Result\":[{\"SL\":1,\"HolidayStartDate\":\"2017-01-01T00:00:00\",\"HolidayEndDate\":\"2017-01-01T00:00:00\",\"Notes\":\"Holiday reason\\t15 Edit done\",\"Status\":1},{\"SL\":2,\"HolidayStartDate\":\"2017-02-21T00:00:00\",\"HolidayEndDate\":\"2017-02-21T00:00:00\",\"Notes\":\"Holiday reason\\t1\",\"Status\":1},{\"SL\":3,\"HolidayStartDate\":\"2017-03-20T00:00:00\",\"HolidayEndDate\":\"2017-03-23T00:00:00\",\"Notes\":\"Holiday reason\\t1\",\"Status\":1},{\"SL\":5,\"HolidayStartDate\":\"2017-03-03T00:00:00\",\"HolidayEndDate\":\"2017-03-03T00:00:00\",\"Notes\":\"Hello world~98\",\"Status\":1},{\"SL\":6,\"HolidayStartDate\":\"2017-03-02T00:00:00\",\"HolidayEndDate\":\"2017-03-04T00:00:00\",\"Notes\":\"asdfasdg adsgdsgdfg\",\"Status\":1},{\"SL\":7,\"HolidayStartDate\":\"2017-03-02T00:00:00\",\"HolidayEndDate\":\"2017-03-04T00:00:00\",\"Notes\":\"Edited data Test\",\"Status\":1},{\"SL\":14,\"HolidayStartDate\":\"2017-03-25T00:00:00\",\"HolidayEndDate\":\"2017-03-26T00:00:00\",\"Notes\":\"Hello World!\",\"Status\":1},{\"SL\":15,\"HolidayStartDate\":\"2017-03-16T00:00:00\",\"HolidayEndDate\":\"2017-03-16T00:00:00\",\"Notes\":\"sdfasdf asdgsdfg\",\"Status\":1},{\"SL\":16,\"HolidayStartDate\":\"2017-03-08T00:00:00\",\"HolidayEndDate\":\"2017-03-16T00:00:00\",\"Notes\":\"asdfs asdfasdf adfgadg asdasdg asgadg\",\"Status\":1},{\"SL\":10018,\"HolidayStartDate\":\"2017-05-17T00:00:00\",\"HolidayEndDate\":\"2017-05-26T00:00:00\",\"Notes\":\"holiday\",\"Status\":1}],\"Id\":8,\"Exception\":null,\"Status\":5,\"IsCanceled\":false,\"IsCompleted\":true,\"CreationOptions\":0,\"AsyncState\":null,\"IsFaulted\":false}";
            var jobj = JObject.Parse(jsonHoliDay);
            List<HoliDay> holiDays = JsonConvert.DeserializeObject<List<HoliDay>>(jobj["Result"].ToString());

            string jsonPeople = "{\"People\":[{\"FirstName\":\"Hans\",\"LastName\":\"Olo\"},{\"FirstName\":\"Jimmy\",\"LastName\":\"Crackedcorn\"}]}";
            var result = JsonConvert.DeserializeObject<RootObject>(jsonPeople);
            var FirstName = result.People.Select(p => p.FirstName).ToList();
            var LastName = result.People.Select(p => p.LastName).ToList();

            holiDays.ForEach(Console.WriteLine);

            foreach (var item in holiDays)
            {
                Console.WriteLine(item.SL + "  " +item.HolidayStartDate.ToString());
            }

            Console.ReadKey();

        }
    }
}
