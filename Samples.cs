
using System.Collections.Generic;
using System.Linq;
using Dapper;

namespace DapperWrapper
{
    public class Examples
    {
        public void Save()
        {
            DAPPERWRAPPER dapper = new DAPPERWRAPPER();
            dapper.AddStringParameter("StringParameterName", StringParameterVariableName, 128);
            dapper.AddGUIDParameter("GUIDParameterName", GUIDParameterVariableName);
            dapper.AddDateTimeParameter("DateTimeParameterName", DateTimeParameterVariableName);
            dapper.AddUnicodeStringParameter("UnicodeStringParameterName", UnicodeStringParameterVariableName, 128);
            dapper.AddBooleanParameter("BooleanParameterName", BooleanParameterVariableName);
            dapper.execute_stored_procedure("dbo.StoredProcedureName");
        }

        public List<CLASSNAME> Get()
        {
            List<CLASSNAME> temp = new List<CLASSNAME>();
            DAPPERWRAPPER dapper = new DAPPERWRAPPER();
            dapper.AddStringParameter("StringParameterName", StringParameterVariableName, 128);
            temp = dapper.execute_stored_procedure<CLASSNAME>("dbo.VehicleManufactureSave");
            return temp;
        }

        public List<CLASSNAME> Get()
        {
            CLASSNAME temp = new CLASSNAME();
            DAPPERWRAPPER dapper = new DAPPERWRAPPER();
            dapper.AddStringParameter("StringParameterName", StringParameterVariableName, 128);
            SqlMapper.GridReader results = dapper.query_multiple("dbo.DepartmentsGet");
            if (results.hasRows())
            {
                temp.ObjectOne = results.Read<OBJECTONETYPE>().ToList();
                temp.ObjectTwo = results.Read<OBJECTTWOTYPE>().FirstOrDefault();
            }

            return temp;
        }

    }
}
