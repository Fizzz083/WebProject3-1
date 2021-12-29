using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MyWebApp.Models
{
    public class problem_info
    {
        public string index{get;set;}
        public string name{get;set;}
        public int rating{get;set;}
    }
    public class submissin
    {
        public int id { get; set; }
        public int contestId { get; set; }

        public int creationTimeSeconds { get; set; }

        public problem_info problem{get;set;}
        public string verdict { get; set; }
    }


    public class publish_submission
    {
        public string user_name{get;set;}
        public string problem_name{get;set;}
        public string problem_id{get;set;}
        public string contest_id{get;set;}
        public string verdict{get;set;}
        public string time_{get;set;}
    }

     public class for_submission
    {

        public string status{get;set;}

        public IList<submissin> result {get;set;}

    }



}

/*
{ "status":"OK",
    "result":
        [{ 
            "id":132923185,
            "contestId":1582,
            "creationTimeSeconds":1635078653,
            "relativeTimeSeconds":8753,
            "problem":
                    { 
                        
                    "contestId":1582,
                    "index":"F2",
                    "name":"Korney Korneevich and XOR (hard version)",
                    "type":"PROGRAMMING",
                    "points":1500.0,
                    "rating":2400,
                    "tags": ["binary search","brute force","dp","greedy","two pointers"]
                    },
            "author":{ 
                        "contestId":1582,"members":
                              [   { "handle":"Fefer_Ivan"}]
                              ,"participantType":"OUT_OF_COMPETITION",
                              "ghost":false,"room":1003,"startTimeSeconds":1635069900
                              },
            "programmingLanguage":"GNU C++17",
            "verdict":"TIME_LIMIT_EXCEEDED",
            "testset":"PRETESTS",
            "passedTestCount":9,
            "timeConsumedMillis":1500,
            "memoryConsumedBytes":536883200}]}
*/