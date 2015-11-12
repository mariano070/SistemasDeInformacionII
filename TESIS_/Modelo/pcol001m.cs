/*
               File: PCOL001m
        Description: ACTUALIZA FECHA ENVIO MAIL A SOPORTE
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:10.22
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
   public class pcol001m : GXProcedure
   {
      public pcol001m( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pcol001m( IGxContext context )
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

      public void execute( ref long aP0_PRC_NRO ,
                           ref DateTime aP1_PRC_EML ,
                           ref String aP2_PRC_MSG )
      {
         this.AV10PRC_NRO = aP0_PRC_NRO;
         this.AV9PRC_EML = aP1_PRC_EML;
         this.AV11PRC_MSG = aP2_PRC_MSG;
         initialize();
         executePrivate();
         aP0_PRC_NRO=this.AV10PRC_NRO;
         aP1_PRC_EML=this.AV9PRC_EML;
         aP2_PRC_MSG=this.AV11PRC_MSG;
      }

      public String executeUdp( ref long aP0_PRC_NRO ,
                                ref DateTime aP1_PRC_EML )
      {
         this.AV10PRC_NRO = aP0_PRC_NRO;
         this.AV9PRC_EML = aP1_PRC_EML;
         this.AV11PRC_MSG = aP2_PRC_MSG;
         initialize();
         executePrivate();
         aP0_PRC_NRO=this.AV10PRC_NRO;
         aP1_PRC_EML=this.AV9PRC_EML;
         aP2_PRC_MSG=this.AV11PRC_MSG;
         return AV11PRC_MSG ;
      }

      public void executeSubmit( ref long aP0_PRC_NRO ,
                                 ref DateTime aP1_PRC_EML ,
                                 ref String aP2_PRC_MSG )
      {
         pcol001m objpcol001m;
         objpcol001m = new pcol001m();
         objpcol001m.AV10PRC_NRO = aP0_PRC_NRO;
         objpcol001m.AV9PRC_EML = aP1_PRC_EML;
         objpcol001m.AV11PRC_MSG = aP2_PRC_MSG;
         objpcol001m.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpcol001m.executePrivateCatch ));
         aP0_PRC_NRO=this.AV10PRC_NRO;
         aP1_PRC_EML=this.AV9PRC_EML;
         aP2_PRC_MSG=this.AV11PRC_MSG;
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
         /* Using cursor P000Y2 */
         pr_default.execute(0, new Object[] {AV10PRC_NRO});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A79PRC_NRO = P000Y2_A79PRC_NRO[0] ;
            A97PRC_EML = P000Y2_A97PRC_EML[0] ;
            A161PRC_MSG = P000Y2_A161PRC_MSG[0] ;
            A97PRC_EML = AV9PRC_EML ;
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11PRC_MSG)) )
            {
               A161PRC_MSG = AV11PRC_MSG ;
            }
            /* Using cursor P000Y3 */
            pr_default.execute(1, new Object[] {A97PRC_EML, A161PRC_MSG, A79PRC_NRO});
            pr_default.close(1);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PCOL001m");
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
         P000Y2_A79PRC_NRO = new long[1] ;
         P000Y2_A97PRC_EML = new DateTime[] {DateTime.MinValue} ;
         P000Y2_A161PRC_MSG = new String[] {""} ;
         A97PRC_EML = (DateTime)(DateTime.MinValue) ;
         A161PRC_MSG = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pcol001m__default(),
            new Object[][] {
                new Object[] {
               P000Y2_A79PRC_NRO, P000Y2_A97PRC_EML, P000Y2_A161PRC_MSG
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private long AV10PRC_NRO ;
      private long A79PRC_NRO ;
      private String AV11PRC_MSG ;
      private String scmdbuf ;
      private String A161PRC_MSG ;
      private DateTime AV9PRC_EML ;
      private DateTime A97PRC_EML ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private long aP0_PRC_NRO ;
      private DateTime aP1_PRC_EML ;
      private String aP2_PRC_MSG ;
      private IDataStoreProvider pr_default ;
      private long[] P000Y2_A79PRC_NRO ;
      private DateTime[] P000Y2_A97PRC_EML ;
      private String[] P000Y2_A161PRC_MSG ;
   }

   public class pcol001m__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000Y2 ;
          prmP000Y2 = new Object[] {
          new Object[] {"@AV10PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmP000Y3 ;
          prmP000Y3 = new Object[] {
          new Object[] {"@PRC_EML",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRC_MSG",SqlDbType.Char,75,0} ,
          new Object[] {"@PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000Y2", "SELECT [PRC_NRO], [PRC_EML], [PRC_MSG] FROM [COL000] WITH (UPDLOCK) WHERE [PRC_NRO] = @AV10PRC_NRO ORDER BY [PRC_NRO] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Y2,1,0,true,true )
             ,new CursorDef("P000Y3", "UPDATE [COL000] SET [PRC_EML]=@PRC_EML, [PRC_MSG]=@PRC_MSG  WHERE [PRC_NRO] = @PRC_NRO", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000Y3)
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 75) ;
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
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (long)parms[2]);
                break;
       }
    }

 }

}
