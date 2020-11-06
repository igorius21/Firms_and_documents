using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ
{
    class Database
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\study.mdf;Integrated Security=True;Connect Timeout=30";

        public string FirmName { get; set; }
        public string CityPostName { get; set; }
        public string CityJurName { get; set; }

        public string SqlRequest1(out string commandText)
        {
            commandText = "select * from firm where UPPER (firm.NAME) = '" + FirmName + "'";
            return connectionString;
        }

        public string SqlRequest2(out string commandText)
        {
            commandText = "select * from firm join city ON firm.JUR_CITY_ID=city.CITY_ID where UPPER (city.NAME) = '" + CityJurName + "'";
            return connectionString;
        }

        public string SqlRequest3(out string commandText)
        {
            commandText = "select * from firm join city ON firm.POST_CITY_ID=city.CITY_ID where UPPER (city.NAME) = '" + CityPostName + "'";
            return connectionString;
        }

        public string SqlRequest4(out string commandText)
        {
            commandText = "select * from firm join city ON ((firm.JUR_CITY_ID=city.CITY_ID) or (firm.POST_CITY_ID=city.CITY_ID)) " +
                "where UPPER(firm.NAME) = '" + FirmName + "' and (UPPER(city.NAME) = '" + CityJurName + "' or UPPER(city.Name) = '" + CityPostName + "')";
            return connectionString;
        }

        public string SqlRequest5(out string commandText)
        {
            commandText = "select * from firm join city ON ((firm.JUR_CITY_ID=city.CITY_ID) and (firm.POST_CITY_ID=city.CITY_ID)) " +
                "where UPPER(city.NAME) = '" + CityPostName + "'";
            return connectionString;
        }

        public string SqlRequest6(out string commandText)
        {
            commandText = "select * from firm join city ON ((firm.JUR_CITY_ID=city.CITY_ID) and (firm.POST_CITY_ID=city.CITY_ID)) " +
                "where UPPER (firm.NAME) = '" + FirmName + "' and UPPER(city.NAME) = '" + CityPostName + "'";
            return connectionString;
        }

        public string SqlRequest7(out string commandText)
        {
            commandText = "select Year(DOC_DATE) , " +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 1 and Year(document.doc_date) = YEAR(document.doc_date)) Январь," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 2 and Year(document.doc_date) = YEAR(document.doc_date)) Февраль," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 3 and Year(document.doc_date) = YEAR(document.doc_date)) Март," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 4 and Year(document.doc_date) = YEAR(document.doc_date)) Апрель," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 5 and Year(document.doc_date) = YEAR(document.doc_date)) Май," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 6 and Year(document.doc_date) = YEAR(document.doc_date)) Июнь," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 7 and Year(document.doc_date) = YEAR(document.doc_date)) Июль," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 8 and Year(document.doc_date) = YEAR(document.doc_date)) Август," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 9 and Year(document.doc_date) = YEAR(document.doc_date)) Сентябрь," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 10 and Year(document.doc_date) = YEAR(document.doc_date)) Октябрь," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 11 and Year(document.doc_date) = YEAR(document.doc_date)) Ноябрь," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 12 and Year(document.doc_date) = YEAR(document.doc_date)) Декабрь" +
                " from document";
            return connectionString;
        }

        public string SqlRequest8(out string commandText)
        {
            commandText = "select Year(DOC_DATE) , " +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 1 and Year(document.doc_date) = YEAR(document.doc_date)) Январь," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 2 and Year(document.doc_date) = YEAR(document.doc_date)) Февраль," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 3 and Year(document.doc_date) = YEAR(document.doc_date)) Март," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 4 and Year(document.doc_date) = YEAR(document.doc_date)) Апрель," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 5 and Year(document.doc_date) = YEAR(document.doc_date)) Май," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 6 and Year(document.doc_date) = YEAR(document.doc_date)) Июнь," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 7 and Year(document.doc_date) = YEAR(document.doc_date)) Июль," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 8 and Year(document.doc_date) = YEAR(document.doc_date)) Август," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 9 and Year(document.doc_date) = YEAR(document.doc_date)) Сентябрь," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 10 and Year(document.doc_date) = YEAR(document.doc_date)) Октябрь," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 11 and Year(document.doc_date) = YEAR(document.doc_date)) Ноябрь," +
                "(select sum(SUM) from document where MONTH(DOC_DATE) = 12 and Year(document.doc_date) = YEAR(document.doc_date)) Декабрь" +
                " from document where document.Firm_id = (select firm.firm_id from firm where firm.name = '" + FirmName + "')";
            return connectionString;
        }
    }
}
