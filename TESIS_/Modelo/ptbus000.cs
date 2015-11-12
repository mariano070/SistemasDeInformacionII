/*
               File: PTBUS000
        Description: Verifica duplicidad de registro
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:7:46.46
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class ptbus000 : GXProcedure
   {
      public ptbus000( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus000( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_BUS_EMP ,
                           short aP1_BUS_RUB ,
                           short aP2_BUS_COD ,
                           short aP3_BUS_PAR ,
                           out short aP4_error )
      {
         this.AV12BUS_EMP = aP0_BUS_EMP;
         this.AV11BUS_RUB = aP1_BUS_RUB;
         this.AV10BUS_COD = aP2_BUS_COD;
         this.AV9BUS_PAR = aP3_BUS_PAR;
         this.AV8error = 0 ;
         initialize();
         executePrivate();
         aP4_error=this.AV8error;
      }

      public short executeUdp( String aP0_BUS_EMP ,
                               short aP1_BUS_RUB ,
                               short aP2_BUS_COD ,
                               short aP3_BUS_PAR )
      {
         this.AV12BUS_EMP = aP0_BUS_EMP;
         this.AV11BUS_RUB = aP1_BUS_RUB;
         this.AV10BUS_COD = aP2_BUS_COD;
         this.AV9BUS_PAR = aP3_BUS_PAR;
         this.AV8error = 0 ;
         initialize();
         executePrivate();
         aP4_error=this.AV8error;
         return AV8error ;
      }

      public void executeSubmit( String aP0_BUS_EMP ,
                                 short aP1_BUS_RUB ,
                                 short aP2_BUS_COD ,
                                 short aP3_BUS_PAR ,
                                 out short aP4_error )
      {
         ptbus000 objptbus000;
         objptbus000 = new ptbus000();
         objptbus000.AV12BUS_EMP = aP0_BUS_EMP;
         objptbus000.AV11BUS_RUB = aP1_BUS_RUB;
         objptbus000.AV10BUS_COD = aP2_BUS_COD;
         objptbus000.AV9BUS_PAR = aP3_BUS_PAR;
         objptbus000.AV8error = 0 ;
         objptbus000.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus000.executePrivateCatch ));
         aP4_error=this.AV8error;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV8error = 0 ;
         /* Using cursor P001I2 */
         pr_default.execute(0, new Object[] {AV12BUS_EMP, AV11BUS_RUB, AV10BUS_COD, AV9BUS_PAR});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A4BUS_PAR = P001I2_A4BUS_PAR[0] ;
            A3BUS_COD = P001I2_A3BUS_COD[0] ;
            A1BUS_RUB = P001I2_A1BUS_RUB[0] ;
            A8BUS_EMP = P001I2_A8BUS_EMP[0] ;
            AV8error = 1 ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "" ;
         P001I2_A4BUS_PAR = new short[1] ;
         P001I2_A3BUS_COD = new short[1] ;
         P001I2_A1BUS_RUB = new short[1] ;
         P001I2_A8BUS_EMP = new String[] {""} ;
         A8BUS_EMP = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus000__default(),
            new Object[][] {
                new Object[] {
               P001I2_A4BUS_PAR, P001I2_A3BUS_COD, P001I2_A1BUS_RUB, P001I2_A8BUS_EMP
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV11BUS_RUB ;
      private short AV10BUS_COD ;
      private short AV9BUS_PAR ;
      private short AV8error ;
      private short A4BUS_PAR ;
      private short A3BUS_COD ;
      private short A1BUS_RUB ;
      private String AV12BUS_EMP ;
      private String scmdbuf ;
      private String A8BUS_EMP ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001I2_A4BUS_PAR ;
      private short[] P001I2_A3BUS_COD ;
      private short[] P001I2_A1BUS_RUB ;
      private String[] P001I2_A8BUS_EMP ;
      private short aP4_error ;
   }

   public class ptbus000__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001I2 ;
          prmP001I2 = new Object[] {
          new Object[] {"@AV12BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@AV11BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001I2", "SELECT [BUS_PAR], [BUS_COD], [BUS_RUB], [BUS_EMP] FROM [BUS000] WITH (NOLOCK) WHERE [BUS_EMP] = @AV12BUS_EMP and [BUS_RUB] = @AV11BUS_RUB and [BUS_COD] = @AV10BUS_COD and [BUS_PAR] = @AV9BUS_PAR ORDER BY [BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001I2,1,0,false,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
       }
    }

 }

}
