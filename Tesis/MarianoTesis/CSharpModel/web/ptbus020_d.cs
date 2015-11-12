/*
               File: PTBUS020_D
        Description: Busco responsable de posición
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:31.50
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
   public class ptbus020_d : GXProcedure
   {
      public ptbus020_d( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus020_d( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( short aP0_TTBUS7_POS ,
                           out String aP1_TTBUS7_CodResp )
      {
         this.AV8TTBUS7_POS = aP0_TTBUS7_POS;
         this.AV9TTBUS7_CodResp = "" ;
         initialize();
         executePrivate();
         aP1_TTBUS7_CodResp=this.AV9TTBUS7_CodResp;
      }

      public String executeUdp( short aP0_TTBUS7_POS )
      {
         this.AV8TTBUS7_POS = aP0_TTBUS7_POS;
         this.AV9TTBUS7_CodResp = "" ;
         initialize();
         executePrivate();
         aP1_TTBUS7_CodResp=this.AV9TTBUS7_CodResp;
         return AV9TTBUS7_CodResp ;
      }

      public void executeSubmit( short aP0_TTBUS7_POS ,
                                 out String aP1_TTBUS7_CodResp )
      {
         ptbus020_d objptbus020_d;
         objptbus020_d = new ptbus020_d();
         objptbus020_d.AV8TTBUS7_POS = aP0_TTBUS7_POS;
         objptbus020_d.AV9TTBUS7_CodResp = "" ;
         objptbus020_d.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus020_d.executePrivateCatch ));
         aP1_TTBUS7_CodResp=this.AV9TTBUS7_CodResp;
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
         AV9TTBUS7_CodResp = "" ;
         /* Using cursor P002X2 */
         pr_default.execute(0, new Object[] {AV8TTBUS7_POS});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A33TTBUS7_Pos = P002X2_A33TTBUS7_Pos[0] ;
            A35TTBUS7_CodResp = P002X2_A35TTBUS7_CodResp[0] ;
            AV9TTBUS7_CodResp = A35TTBUS7_CodResp ;
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
         P002X2_A33TTBUS7_Pos = new short[1] ;
         P002X2_A35TTBUS7_CodResp = new String[] {""} ;
         A35TTBUS7_CodResp = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus020_d__default(),
            new Object[][] {
                new Object[] {
               P002X2_A33TTBUS7_Pos, P002X2_A35TTBUS7_CodResp
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV8TTBUS7_POS ;
      private short A33TTBUS7_Pos ;
      private String AV9TTBUS7_CodResp ;
      private String scmdbuf ;
      private String A35TTBUS7_CodResp ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P002X2_A33TTBUS7_Pos ;
      private String[] P002X2_A35TTBUS7_CodResp ;
      private String aP1_TTBUS7_CodResp ;
   }

   public class ptbus020_d__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP002X2 ;
          prmP002X2 = new Object[] {
          new Object[] {"@AV8TTBUS7_POS",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002X2", "SELECT [TTBUS7_Pos], [TTBUS7_CodResp] FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV8TTBUS7_POS ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002X2,1,0,false,true )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
