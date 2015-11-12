/*
               File: PTBUS020_A
        Description: Busca Descripción de Responsable de Envío
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:45.49
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
   public class ptbus020_a : GXProcedure
   {
      public ptbus020_a( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus020_a( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( short aP0_TTBUS7_Pos ,
                           out String aP1_dSEC_CRE ,
                           out String aP2_SEC_DRE )
      {
         this.AV8TTBUS7_Pos = aP0_TTBUS7_Pos;
         this.AV9dSEC_CRE = "" ;
         this.AV10SEC_DRE = "" ;
         initialize();
         executePrivate();
         aP1_dSEC_CRE=this.AV9dSEC_CRE;
         aP2_SEC_DRE=this.AV10SEC_DRE;
      }

      public String executeUdp( short aP0_TTBUS7_Pos ,
                                out String aP1_dSEC_CRE )
      {
         this.AV8TTBUS7_Pos = aP0_TTBUS7_Pos;
         this.AV9dSEC_CRE = "" ;
         this.AV10SEC_DRE = "" ;
         initialize();
         executePrivate();
         aP1_dSEC_CRE=this.AV9dSEC_CRE;
         aP2_SEC_DRE=this.AV10SEC_DRE;
         return AV10SEC_DRE ;
      }

      public void executeSubmit( short aP0_TTBUS7_Pos ,
                                 out String aP1_dSEC_CRE ,
                                 out String aP2_SEC_DRE )
      {
         ptbus020_a objptbus020_a;
         objptbus020_a = new ptbus020_a();
         objptbus020_a.AV8TTBUS7_Pos = aP0_TTBUS7_Pos;
         objptbus020_a.AV9dSEC_CRE = "" ;
         objptbus020_a.AV10SEC_DRE = "" ;
         objptbus020_a.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus020_a.executePrivateCatch ));
         aP1_dSEC_CRE=this.AV9dSEC_CRE;
         aP2_SEC_DRE=this.AV10SEC_DRE;
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
         AV9dSEC_CRE = "" ;
         AV10SEC_DRE = "" ;
         AV11SESION.Set("RespEnvio", AV9dSEC_CRE);
         /* Using cursor P002T2 */
         pr_default.execute(0, new Object[] {AV8TTBUS7_Pos});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A33TTBUS7_Pos = P002T2_A33TTBUS7_Pos[0] ;
            A35TTBUS7_CodResp = P002T2_A35TTBUS7_CodResp[0] ;
            A36TTBUS7_DesResp = P002T2_A36TTBUS7_DesResp[0] ;
            n36TTBUS7_DesResp = P002T2_n36TTBUS7_DesResp[0] ;
            A36TTBUS7_DesResp = P002T2_A36TTBUS7_DesResp[0] ;
            n36TTBUS7_DesResp = P002T2_n36TTBUS7_DesResp[0] ;
            AV9dSEC_CRE = A35TTBUS7_CodResp ;
            AV10SEC_DRE = A36TTBUS7_DesResp ;
            AV11SESION.Set("RespEnvio", AV9dSEC_CRE);
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
         AV11SESION = new GxWebSession( context);
         scmdbuf = "" ;
         P002T2_A33TTBUS7_Pos = new short[1] ;
         P002T2_A35TTBUS7_CodResp = new String[] {""} ;
         P002T2_A36TTBUS7_DesResp = new String[] {""} ;
         P002T2_n36TTBUS7_DesResp = new bool[] {false} ;
         A35TTBUS7_CodResp = "" ;
         A36TTBUS7_DesResp = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus020_a__default(),
            new Object[][] {
                new Object[] {
               P002T2_A33TTBUS7_Pos, P002T2_A35TTBUS7_CodResp, P002T2_A36TTBUS7_DesResp, P002T2_n36TTBUS7_DesResp
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV8TTBUS7_Pos ;
      private short A33TTBUS7_Pos ;
      private String AV10SEC_DRE ;
      private String AV9dSEC_CRE ;
      private String scmdbuf ;
      private String A35TTBUS7_CodResp ;
      private String A36TTBUS7_DesResp ;
      private bool n36TTBUS7_DesResp ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P002T2_A33TTBUS7_Pos ;
      private String[] P002T2_A35TTBUS7_CodResp ;
      private String[] P002T2_A36TTBUS7_DesResp ;
      private bool[] P002T2_n36TTBUS7_DesResp ;
      private String aP1_dSEC_CRE ;
      private String aP2_SEC_DRE ;
      private GxWebSession AV11SESION ;
   }

   public class ptbus020_a__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP002T2 ;
          prmP002T2 = new Object[] {
          new Object[] {"@AV8TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002T2", "SELECT T1.[TTBUS7_Pos], T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T2.[USU_DES] AS TTBUS7_DesResp FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodResp]) WHERE T1.[TTBUS7_Pos] = @AV8TTBUS7_Pos ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002T2,1,0,false,true )
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
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
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
