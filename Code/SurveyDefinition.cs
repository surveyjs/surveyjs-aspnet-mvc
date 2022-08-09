using System;
using System.Collections.Generic;
using System.Linq;

namespace surveyjs_aspnet_mvc
{

    [Serializable]
    public class SurveyDefinition
    {
        public string id { get; set; }
        public string name { get; set; }
        public string json { get; set; }

        private static int currentId = 3;
        public static SurveyDefinition Create()
        {
            return new SurveyDefinition { id = "" + currentId, name = "New Survey " + currentId++, json = "{}" };
        }
        public static SurveyDefinition FindById(IEnumerable<SurveyDefinition> collection, string id)
        {
            return collection.Where(s => s.id == id).FirstOrDefault();
        }

        public static List<SurveyDefinition> GetDefaultSurveys()
        {
            SurveyDefinition survey1 = new SurveyDefinition
            {
                id = "1",
                name = "Product Feedback Survey",
                json = @"{
                    ""pages"": [
                    {
                    ""elements"": [
                    {
                        ""type"": ""matrix"",
                        ""name"": ""Quality"",
                        ""title"": ""Please indicate if you agree or disagree with the following statements"",
                        ""columns"": [
                        {
                        ""value"": 1,
                        ""text"": ""Strongly disagree""
                        },
                        {
                        ""value"": 2,
                        ""text"": ""Disagree""
                        },
                        {
                        ""value"": 3,
                        ""text"": ""Neutral""
                        },
                        {
                        ""value"": 4,
                        ""text"": ""Agree""
                        },
                        {
                        ""value"": 5,
                        ""text"": ""Strongly agree""
                        }
                        ],
                        ""rows"": [
                        {
                        ""value"": ""affordable"",
                        ""text"": ""Product is affordable""
                        },
                        {
                        ""value"": ""does what it claims"",
                        ""text"": ""Product does what it claims""
                        },
                        {
                        ""value"": ""better then others"",
                        ""text"": ""Product is better than other products on the market""
                        },
                        {
                        ""value"": ""easy to use"",
                        ""text"": ""Product is easy to use""
                        }
                        ]
                    },
                    {
                        ""type"": ""rating"",
                        ""name"": ""satisfaction"",
                        ""title"": ""How satisfied are you with the product?"",
                        ""minRateDescription"": ""Not satisfied"",
                        ""maxRateDescription"": ""Completely satisfied""
                    },
                    {
                        ""type"": ""rating"",
                        ""name"": ""recommend friends"",
                        ""visible"": false,
                        ""visibleIf"": ""{satisfaction} > 3"",
                        ""title"": ""How likely are you to recommend the product to a friend or colleague?"",
                        ""minRateDescription"": ""Won't recommend"",
                        ""maxRateDescription"": ""Will recommend""
                    },
                    {
                        ""type"": ""comment"",
                        ""name"": ""suggestions"",
                        ""title"": ""What would make you more satisfied with the product?""
                    }
                    ]
                    },
                    {
                    ""elements"": [
                    {
                        ""type"": ""radiogroup"",
                        ""name"": ""price to competitors"",
                        ""title"": ""Compared to our competitors, do you feel the product is"",
                        ""choices"": [
                        ""Less expensive"",
                        ""Priced about the same"",
                        ""More expensive"",
                        ""Not sure""
                        ]
                    },
                    {
                        ""type"": ""radiogroup"",
                        ""name"": ""price"",
                        ""title"": ""Do you feel our current price is merited by our product?"",
                        ""choices"": [
                        {
                        ""value"": ""correct"",
                        ""text"": ""Yes, the price is about right""
                        },
                        {
                        ""value"": ""low"",
                        ""text"": ""No, the price is too low""
                        },
                        {
                        ""value"": ""high"",
                        ""text"": ""No, the price is too high""
                        }
                        ]
                    },
                    {
                        ""type"": ""multipletext"",
                        ""name"": ""pricelimit"",
                        ""title"": ""What is the... "",
                        ""items"": [
                        {
                        ""name"": ""mostamount"",
                        ""title"": ""Most amount you would pay for a product like ours""
                        },
                        {
                        ""name"": ""leastamount"",
                        ""title"": ""The least amount you would feel comfortable paying""
                        }
                        ]
                    }
                    ]
                    },
                    {
                    ""elements"": [
                    {
                        ""type"": ""text"",
                        ""name"": ""email"",
                        ""title"": ""Thank you for taking our survey. Please enter your email address and press the \""Submit\"" button.""
                    }
                    ]
                    }
                    ]
                }"
            };

            SurveyDefinition survey2 = new SurveyDefinition
            {
                id = "2",
                name = "Customer and their partner income survey",
                json = @"{
                    ""completeText"": ""Finish"",
                    ""pageNextText"": ""Continue"",
                    ""pagePrevText"": ""Previous"",
                    ""pages"": [
                        {
                            ""elements"": [
                                {
                                    ""type"": ""panel"",
                                    ""elements"": [
                                        {
                                            ""type"": ""html"",
                                            ""name"": ""income_intro"",
                                            ""html"": ""Income. In this section, you will be asked about your current employment status and other ways you and your partner receive income. It will be handy to have the following in front of you: payslip (for employment details), latest statement from any payments (from Centrelink or other authority), a current Centrelink Schedule for any account-based pension from super, annuities, or other income stream products that you may own. If you don't have a current one, you can get these schedules by contacting your income stream provider.""
                                        }
                                    ],
                                    ""name"": ""panel1""
                                }
                            ],
                            ""name"": ""page0""
                        }, {
                            ""elements"": [
                                {
                                    ""type"": ""panel"",
                                    ""elements"": [
                                        {
                                            ""type"": ""radiogroup"",
                                            ""choices"": [
                                                ""Married"", ""In a registered relationship"", ""Living with my partner"", ""Widowed"", ""Single""
                                            ],
                                            ""name"": ""maritalstatus_c"",
                                            ""title"": "" ""
                                        }
                                    ],
                                    ""name"": ""panel13"",
                                    ""title"": ""What is your marital status?""
                                }
                            ],
                            ""name"": ""page1""
                        }, {
                            ""elements"": [
                                {
                                    ""type"": ""panel"",
                                    ""elements"": [
                                        {
                                            ""type"": ""panel"",
                                            ""elements"": [
                                                {
                                                    ""type"": ""radiogroup"",
                                                    ""choices"": [
                                                        {
                                                            ""value"": ""1"",
                                                            ""text"": ""Yes""
                                                        }, {
                                                            ""value"": ""0"",
                                                            ""text"": ""No""
                                                        }
                                                    ],
                                                    ""colCount"": 2,
                                                    ""isRequired"": true,
                                                    ""name"": ""member_receives_income_from_employment"",
                                                    ""title"": "" ""
                                                }, {
                                                    ""type"": ""checkbox"",
                                                    ""name"": ""member_type_of_employment"",
                                                    ""visible"": false,
                                                    ""visibleIf"": ""{member_receives_income_from_employment} =1"",
                                                    ""title"": ""  "",
                                                    ""isRequired"": true,
                                                    ""choices"": [""Self-employed"", ""Other types of employment""]
                                                }
                                            ],
                                            ""name"": ""panel2"",
                                            ""title"": ""You""
                                        }, {
                                            ""type"": ""panel"",
                                            ""elements"": [
                                                {
                                                    ""type"": ""radiogroup"",
                                                    ""choices"": [
                                                        {
                                                            ""value"": ""1"",
                                                            ""text"": ""Yes""
                                                        }, {
                                                            ""value"": ""0"",
                                                            ""text"": ""No""
                                                        }
                                                    ],
                                                    ""colCount"": 2,
                                                    ""isRequired"": true,
                                                    ""name"": ""partner_receives_income_from_employment"",
                                                    ""title"": "" ""
                                                }, {
                                                    ""type"": ""checkbox"",
                                                    ""name"": ""partner_type_of_employment"",
                                                    ""visible"": false,
                                                    ""visibleIf"": ""{partner_receives_income_from_employment} =1"",
                                                    ""title"": "" "",
                                                    ""isRequired"": true,
                                                    ""choices"": [""Self-employed"", ""Other types of employment""]
                                                }
                                            ],
                                            ""name"": ""panel1"",
                                            ""startWithNewLine"": false,
                                            ""title"": ""Your partner"",
                                            ""visible"": false,
                                            ""visibleIf"": ""{maritalstatus_c} = 'Married' or {maritalstatus_c} = 'In a registered relationship' or {maritalstatus_c} = 'Living with my partner'""
                                        }
                                    ],
                                    ""name"": ""panel5"",
                                    ""title"": ""Do you and/or your partner currently receive income from employment?""
                                }
                            ],
                            ""name"": ""page2""
                        }, {
                            ""elements"": [
                                {
                                    ""type"": ""panel"",
                                    ""elements"": [
                                        {
                                            ""type"": ""panel"",
                                            ""elements"": [
                                                {
                                                    ""type"": ""paneldynamic"",
                                                    ""minPanelCount"": 1,
                                                    ""name"": ""member_array_employer_names"",
                                                    ""valueName"": ""member_array_employer"",
                                                    ""title"": ""Enter information about your employers"",
                                                    ""panelAddText"": ""Add another employer"",
                                                    ""panelCount"": 1,
                                                    ""templateElements"": [
                                                        {
                                                            ""type"": ""text"",
                                                            ""name"": ""member_employer_name"",
                                                            ""valueName"": ""name"",
                                                            ""title"": ""Employer name""
                                                        }
                                                    ]
                                                }
                                            ],
                                            ""name"": ""panel2"",
                                            ""title"": ""You"",
                                            ""visible"": false,
                                            ""visibleIf"": ""{member_type_of_employment} contains 'Other types of employment'""
                                        }, {
                                            ""type"": ""panel"",
                                            ""elements"": [
                                                {
                                                    ""type"": ""paneldynamic"",
                                                    ""minPanelCount"": 1,
                                                    ""name"": ""partner_array_employer_names"",
                                                    ""valueName"": ""partner_array_employer"",
                                                    ""title"": ""Enter information about employers of your partner"",
                                                    ""panelAddText"": ""Add another employer"",
                                                    ""panelCount"": 1,
                                                    ""templateElements"": [
                                                        {
                                                            ""type"": ""text"",
                                                            ""name"": ""partner_employer_name"",
                                                            ""valueName"": ""name"",
                                                            ""title"": ""Employer name""
                                                        }
                                                    ]
                                                }
                                            ],
                                            ""name"": ""panel8"",
                                            ""startWithNewLine"": false,
                                            ""title"": ""Your partner"",
                                            ""visible"": false,
                                            ""visibleIf"": ""{partner_type_of_employment} contains 'Other types of employment'""
                                        }
                                    ],
                                    ""name"": ""panel6"",
                                    ""title"": ""Employers""
                                }
                            ],
                            ""name"": ""page3.1"",
                            ""visible"": false,
                            ""visibleIf"": ""{member_type_of_employment} contains 'Other types of employment' or {partner_type_of_employment} contains 'Other types of employment'""
                        }, {
                            ""elements"": [
                                {
                                    ""type"": ""panel"",
                                    ""elements"": [
                                        {
                                            ""type"": ""panel"",
                                            ""elements"": [
                                                {
                                                    ""type"": ""paneldynamic"",
                                                    ""renderMode"": ""progressTop"",
                                                    ""allowAddPanel"": false,
                                                    ""allowRemovePanel"": false,
                                                    ""name"": ""member_array_employer_info"",
                                                    ""title"": ""Your employers"",
                                                    ""valueName"": ""member_array_employer"",
                                                    ""panelCount"": 1,
                                                    ""templateElements"": [
                                                        {
                                                            ""type"": ""panel"",
                                                            ""name"": ""panel_member_employer_address"",
                                                            ""title"": ""Contacts"",
                                                            ""elements"": [
                                                                {
                                                                    ""type"": ""text"",
                                                                    ""name"": ""member_employer_address"",
                                                                    ""valueName"": ""address"",
                                                                    ""title"": ""Address:""
                                                                }, {
                                                                    ""type"": ""text"",
                                                                    ""name"": ""member_employer_phone"",
                                                                    ""valueName"": ""phone"",
                                                                    ""title"": ""Phone number:""
                                                                }, {
                                                                    ""type"": ""text"",
                                                                    ""name"": ""member_employer_abn"",
                                                                    ""valueName"": ""abn"",
                                                                    ""title"": ""ABN:""
                                                                }
                                                            ]
                                                        }, {
                                                            ""type"": ""panel"",
                                                            ""name"": ""panel_member_employer_role"",
                                                            ""title"": ""Are you a full time worker?"",
                                                            ""elements"": [
                                                                {
                                                                    ""type"": ""radiogroup"",
                                                                    ""choices"": [
                                                                        ""Full-time"", ""Part-time"", ""Casual"", ""Seasonal""
                                                                    ],
                                                                    ""name"": ""member_employer_role"",
                                                                    ""title"": "" "",
                                                                    ""valueName"": ""role""
                                                                }
                                                            ]
                                                        }, {
                                                            ""type"": ""panel"",
                                                            ""name"": ""panel_member_employer_hours_work"",
                                                            ""title"": ""How many hours do you work?"",
                                                            ""elements"": [
                                                                {
                                                                    ""type"": ""text"",
                                                                    ""inputType"": ""number"",
                                                                    ""name"": ""member_employer_hours_worked"",
                                                                    ""valueName"": ""hours_worked"",
                                                                    ""title"": ""Hours:""
                                                                }, {
                                                                    ""type"": ""dropdown"",
                                                                    ""name"": ""member_employer_hours_worked_frequency"",
                                                                    ""title"": ""Work frequency:"",
                                                                    ""valueName"": ""hours_worked_frequency"",
                                                                    ""startWithNewLine"": false,
                                                                    ""defaultValue"": ""Day"",
                                                                    ""choices"": [""Day"", ""Week"", ""Fortnight"", ""Month"", ""Year""]
                                                                }
                                                            ]
                                                        }, {
                                                            ""type"": ""panel"",
                                                            ""name"": ""panel_member_employer_income"",
                                                            ""title"": ""What is your income?"",
                                                            ""elements"": [
                                                                {
                                                                    ""type"": ""text"",
                                                                    ""inputType"": ""number"",
                                                                    ""name"": ""member_employer_income"",
                                                                    ""valueName"": ""income"",
                                                                    ""title"": ""Income:""
                                                                }, {
                                                                    ""type"": ""dropdown"",
                                                                    ""name"": ""member_employer_income_frequency"",
                                                                    ""title"": ""Income frequency:"",
                                                                    ""valueName"": ""income_frequency"",
                                                                    ""startWithNewLine"": false,
                                                                    ""defaultValue"": ""Month"",
                                                                    ""choices"": [""Day"", ""Week"", ""Fortnight"", ""Month"", ""Year""]
                                                                }
                                                            ]
                                                        }
                                                    ],
                                                    ""templateTitle"": ""Employer name: {panel.name}""
                                                }
                                            ],
                                            ""name"": ""panel17"",
                                            ""title"": ""You"",
                                            ""visibleIf"": ""{member_type_of_employment} contains 'Other types of employment'""
                                        }, {
                                            ""type"": ""panel"",
                                            ""elements"": [
                                                {
                                                    ""type"": ""paneldynamic"",
                                                    ""renderMode"": ""progressTop"",
                                                    ""allowAddPanel"": false,
                                                    ""allowRemovePanel"": false,
                                                    ""name"": ""partner_array_employer_info"",
                                                    ""title"": ""Employers"",
                                                    ""valueName"": ""partner_array_employer"",
                                                    ""panelCount"": 1,
                                                    ""templateElements"": [
                                                        {
                                                            ""type"": ""panel"",
                                                            ""name"": ""panel_partner_employer_address"",
                                                            ""title"": ""Contacts"",
                                                            ""elements"": [
                                                                {
                                                                    ""type"": ""text"",
                                                                    ""name"": ""partner_employer_address"",
                                                                    ""valueName"": ""address"",
                                                                    ""title"": ""Address:""
                                                                }, {
                                                                    ""type"": ""text"",
                                                                    ""name"": ""partner_employer_phone"",
                                                                    ""valueName"": ""phone"",
                                                                    ""title"": ""Phone number:""
                                                                }, {
                                                                    ""type"": ""text"",
                                                                    ""name"": ""partner_employer_abn"",
                                                                    ""valueName"": ""abn"",
                                                                    ""title"": ""ABN:""
                                                                }
                                                            ]
                                                        }, {
                                                            ""type"": ""panel"",
                                                            ""name"": ""panel_partner_employer_role"",
                                                            ""title"": ""Are you a full time worker?"",
                                                            ""elements"": [
                                                                {
                                                                    ""type"": ""radiogroup"",
                                                                    ""choices"": [
                                                                        ""Full-time"", ""Part-time"", ""Casual"", ""Seasonal""
                                                                    ],
                                                                    ""name"": ""partner_employer_role"",
                                                                    ""title"": "" "",
                                                                    ""valueName"": ""role""
                                                                }
                                                            ]
                                                        }, {
                                                            ""type"": ""panel"",
                                                            ""name"": ""panel_partner_employer_hours_work"",
                                                            ""title"": ""How many hours do you work?"",
                                                            ""elements"": [
                                                                {
                                                                    ""type"": ""text"",
                                                                    ""inputType"": ""number"",
                                                                    ""name"": ""partner_employer_hours_worked"",
                                                                    ""valueName"": ""hours_worked"",
                                                                    ""title"": ""Hours:""
                                                                }, {
                                                                    ""type"": ""dropdown"",
                                                                    ""name"": ""partner_employer_hours_worked_frequency"",
                                                                    ""valueName"": ""hours_worked_frequency"",
                                                                    ""title"": ""Work frequency:"",
                                                                    ""startWithNewLine"": false,
                                                                    ""defaultValue"": ""Day"",
                                                                    ""choices"": [""Day"", ""Week"", ""Fortnight"", ""Month"", ""Year""]
                                                                }
                                                            ]
                                                        }, {
                                                            ""type"": ""panel"",
                                                            ""name"": ""panel_partner_employer_income"",
                                                            ""title"": ""What is your income?"",
                                                            ""elements"": [
                                                                {
                                                                    ""type"": ""text"",
                                                                    ""inputType"": ""number"",
                                                                    ""name"": ""partner_employer_income"",
                                                                    ""valueName"": ""income"",
                                                                    ""title"": ""Income:""
                                                                }, {
                                                                    ""type"": ""dropdown"",
                                                                    ""name"": ""partner_employer_income_frequency"",
                                                                    ""valueName"": ""income_frequency"",
                                                                    ""title"": ""Income frequency:"",
                                                                    ""startWithNewLine"": false,
                                                                    ""defaultValue"": ""Month"",
                                                                    ""choices"": [""Day"", ""Week"", ""Fortnight"", ""Month"", ""Year""]
                                                                }
                                                            ]
                                                        }
                                                    ],
                                                    ""templateTitle"": ""Employer name: {panel.name}""
                                                }
                                            ],
                                            ""name"": ""panel18"",
                                            ""startWithNewLine"": false,
                                            ""title"": ""Your partner"",
                                            ""visibleIf"": ""{partner_type_of_employment} contains 'Other types of employment'""
                                        }
                                    ],
                                    ""name"": ""panel16"",
                                    ""title"": ""Enter information about your employers""
                                }
                            ],
                            ""name"": ""page3.2"",
                            ""visibleIf"": ""{member_type_of_employment} contains 'Other types of employment' or {partner_type_of_employment} contains 'Other types of employment'""
                        }, {
                            ""elements"": [
                                {
                                    ""type"": ""panel"",
                                    ""elements"": [
                                        {
                                            ""type"": ""panel"",
                                            ""elements"": [
                                                {
                                                    ""type"": ""radiogroup"",
                                                    ""choices"": [
                                                        {
                                                            ""value"": ""1"",
                                                            ""text"": ""Yes""
                                                        }, {
                                                            ""value"": ""0"",
                                                            ""text"": ""No""
                                                        }
                                                    ],
                                                    ""colCount"": 2,
                                                    ""isRequired"": true,
                                                    ""name"": ""member_receive_fringe_benefits"",
                                                    ""title"": "" ""
                                                }, {
                                                    ""type"": ""panel"",
                                                    ""elements"": [
                                                        {
                                                            ""type"": ""text"",
                                                            ""name"": ""member_fringe_benefits_type""
                                                        }, {
                                                            ""type"": ""text"",
                                                            ""name"": ""member_fringe_benefits_value""
                                                        }, {
                                                            ""type"": ""radiogroup"",
                                                            ""choices"": [
                                                                ""Grossed up"", ""Not grossed up""
                                                            ],
                                                            ""name"": ""member_fringe_benefits_grossing""
                                                        }
                                                    ],
                                                    ""name"": ""panel11"",
                                                    ""visible"": false,
                                                    ""visibleIf"": ""{member_receive_fringe_benefits} = 1""
                                                }
                                            ],
                                            ""name"": ""panel2"",
                                            ""title"": ""You"",
                                            ""visible"": false,
                                            ""visibleIf"": ""{member_type_of_employment} contains 'Other types of employment'""
                                        }, {
                                            ""type"": ""panel"",
                                            ""elements"": [
                                                {
                                                    ""type"": ""radiogroup"",
                                                    ""choices"": [
                                                        {
                                                            ""value"": ""1"",
                                                            ""text"": ""Yes""
                                                        }, {
                                                            ""value"": ""0"",
                                                            ""text"": ""No""
                                                        }
                                                    ],
                                                    ""colCount"": 2,
                                                    ""isRequired"": true,
                                                    ""name"": ""partner_receive_fringe_benefits"",
                                                    ""title"": "" ""
                                                }, {
                                                    ""type"": ""panel"",
                                                    ""elements"": [
                                                        {
                                                            ""type"": ""text"",
                                                            ""name"": ""partner_fringe_benefits_type""
                                                        }, {
                                                            ""type"": ""text"",
                                                            ""name"": ""partner_fringe_benefits_value""
                                                        }, {
                                                            ""type"": ""radiogroup"",
                                                            ""choices"": [
                                                                ""Grossed up"", ""Not grossed up""
                                                            ],
                                                            ""name"": ""partner_fringe_benefits_grossing""
                                                        }
                                                    ],
                                                    ""name"": ""panel12"",
                                                    ""visible"": false,
                                                    ""visibleIf"": ""{partner_receive_fringe_benefits} = 1""
                                                }
                                            ],
                                            ""name"": ""panel1"",
                                            ""startWithNewLine"": false,
                                            ""title"": ""Your Partner"",
                                            ""visible"": false,
                                            ""visibleIf"": ""{partner_type_of_employment} contains 'Other types of employment'""
                                        }
                                    ],
                                    ""name"": ""panel9"",
                                    ""title"": ""Do any of your employers provide you with fringe benefits?""
                                }
                            ],
                            ""name"": ""page4"",
                            ""visible"": false,
                            ""visibleIf"": ""{member_type_of_employment} contains 'Other types of employment' or {partner_type_of_employment} contains 'Other types of employment'""
                        }, {
                            ""elements"": [
                                {
                                    ""type"": ""panel"",
                                    ""elements"": [
                                        {
                                            ""type"": ""panel"",
                                            ""elements"": [
                                                {
                                                    ""type"": ""radiogroup"",
                                                    ""choices"": [
                                                        {
                                                            ""value"": ""1"",
                                                            ""text"": ""Yes""
                                                        }, {
                                                            ""value"": ""0"",
                                                            ""text"": ""No""
                                                        }
                                                    ],
                                                    ""colCount"": 2,
                                                    ""isRequired"": true,
                                                    ""name"": ""member_seasonal_intermittent_or_contract_work"",
                                                    ""title"": "" ""
                                                }
                                            ],
                                            ""name"": ""panel2"",
                                            ""title"": ""You"",
                                            ""visible"": false,
                                            ""visibleIf"": ""{member_receives_income_from_employment} = 1""
                                        }, {
                                            ""type"": ""panel"",
                                            ""elements"": [
                                                {
                                                    ""type"": ""radiogroup"",
                                                    ""choices"": [
                                                        {
                                                            ""value"": ""1"",
                                                            ""text"": ""Yes""
                                                        }, {
                                                            ""value"": ""0"",
                                                            ""text"": ""No""
                                                        }
                                                    ],
                                                    ""colCount"": 2,
                                                    ""isRequired"": true,
                                                    ""name"": ""partner_seasonal_intermittent_or_contract_work"",
                                                    ""title"": "" ""
                                                }
                                            ],
                                            ""name"": ""panel1"",
                                            ""startWithNewLine"": false,
                                            ""title"": ""Your Partner"",
                                            ""visible"": false,
                                            ""visibleIf"": ""{partner_receives_income_from_employment} =1 ""
                                        }
                                    ],
                                    ""name"": ""panel10"",
                                    ""title"": ""In the last 6 months, have you done any seasonal, intermittent or contract work?""
                                }
                            ],
                            ""name"": ""page5"",
                            ""visible"": false,
                            ""visibleIf"": ""{member_receives_income_from_employment} = 1 or {partner_receives_income_from_employment} =1 ""
                        }
                    ],
                    ""requiredText"": """",
                    ""showQuestionNumbers"": ""off"",
                    ""storeOthersAsComment"": false
                }"
            };

            List<SurveyDefinition> defaultSurveys = new List<SurveyDefinition> { survey1, survey2 };
            return defaultSurveys;
        }
    }

}