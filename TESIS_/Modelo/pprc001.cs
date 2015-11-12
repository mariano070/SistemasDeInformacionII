/*
               File: PPRC001
        Description: EJECUTA UN PROCESO DE LA COLA BATCH
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:11.25
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
   public class pprc001 : GXProcedure
   {
      public pprc001( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pprc001( IGxContext context )
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

      public void execute( ref long aP0_PRC_NRO )
      {
         this.A79PRC_NRO = aP0_PRC_NRO;
         initialize();
         executePrivate();
         aP0_PRC_NRO=this.A79PRC_NRO;
      }

      public long executeUdp( )
      {
         this.A79PRC_NRO = aP0_PRC_NRO;
         initialize();
         executePrivate();
         aP0_PRC_NRO=this.A79PRC_NRO;
         return A79PRC_NRO ;
      }

      public void executeSubmit( ref long aP0_PRC_NRO )
      {
         pprc001 objpprc001;
         objpprc001 = new pprc001();
         objpprc001.A79PRC_NRO = aP0_PRC_NRO;
         objpprc001.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpprc001.executePrivateCatch ));
         aP0_PRC_NRO=this.A79PRC_NRO;
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
         /* Using cursor P000T2 */
         pr_default.execute(0, new Object[] {A79PRC_NRO});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A160PRC_INV = P000T2_A160PRC_INV[0] ;
            A158PRC_EST = P000T2_A158PRC_EST[0] ;
            A96PRC_INI = P000T2_A96PRC_INI[0] ;
            if ( StringUtil.StrCmp(A160PRC_INV, " ") == 0 )
            {
               A158PRC_EST = 5 ;
               AV11AHORA = DateTimeUtil.ServerNow( context, "DEFAULT") ;
               A96PRC_INI = AV11AHORA ;
            }
            /* Using cursor P000T3 */
            pr_default.execute(1, new Object[] {A158PRC_EST, A96PRC_INI, A79PRC_NRO});
            pr_default.close(1);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PPRC001");
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
         P000T2_A79PRC_NRO = new long[1] ;
         P000T2_A160PRC_INV = new String[] {""} ;
         P000T2_A158PRC_EST = new short[1] ;
         P000T2_A96PRC_INI = new DateTime[] {DateTime.MinValue} ;
         A160PRC_INV = "" ;
         A96PRC_INI = (DateTime)(DateTime.MinValue) ;
         AV11AHORA = (DateTime)(DateTime.MinValue) ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pprc001__default(),
            new Object[][] {
                new Object[] {
               P000T2_A79PRC_NRO, P000T2_A160PRC_INV, P000T2_A158PRC_EST, P000T2_A96PRC_INI
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A158PRC_EST ;
      private long A79PRC_NRO ;
      private String scmdbuf ;
      private String A160PRC_INV ;
      private DateTime A96PRC_INI ;
      private DateTime AV11AHORA ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private long aP0_PRC_NRO ;
      private IDataStoreProvider pr_default ;
      private long[] P000T2_A79PRC_NRO ;
      private String[] P000T2_A160PRC_INV ;
      private short[] P000T2_A158PRC_EST ;
      private DateTime[] P000T2_A96PRC_INI ;
   }

   public class pprc001__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000T2 ;
          prmP000T2 = new Object[] {
          new Object[] {"@PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmP000T3 ;
          prmP000T3 = new Object[] {
          new Object[] {"@PRC_EST",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@PRC_INI",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000T2", "SELECT [PRC_NRO], [PRC_INV], [PRC_EST], [PRC_INI] FROM [COL000] WITH (UPDLOCK) WHERE [PRC_NRO] = @PRC_NRO ORDER BY [PRC_NRO] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000T2,1,0,true,true )
             ,new CursorDef("P000T3", "UPDATE [COL000] SET [PRC_EST]=@PRC_EST, [PRC_INI]=@PRC_INI  WHERE [PRC_NRO] = @PRC_NRO", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000T3)
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
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (long)parms[2]);
                break;
       }
    }

 }

}
