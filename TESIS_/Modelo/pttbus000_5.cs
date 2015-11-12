/*
               File: PTTBUS000_5
        Description: Busco responsable
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:3.27
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
   public class pttbus000_5 : GXProcedure
   {
      public pttbus000_5( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pttbus000_5( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( int aP0_TTBUS_Id ,
                           short aP1_TTBUS_CodPosicion ,
                           out String aP2_TTBUS_DesPosicion ,
                           out String aP3_SEC_CRE ,
                           out String aP4_SEC_DRE )
      {
         this.AV12TTBUS_Id = aP0_TTBUS_Id;
         this.AV10TTBUS_CodPosicion = aP1_TTBUS_CodPosicion;
         this.AV11TTBUS_DesPosicion = "" ;
         this.AV8SEC_CRE = "" ;
         this.AV9SEC_DRE = "" ;
         initialize();
         executePrivate();
         aP2_TTBUS_DesPosicion=this.AV11TTBUS_DesPosicion;
         aP3_SEC_CRE=this.AV8SEC_CRE;
         aP4_SEC_DRE=this.AV9SEC_DRE;
      }

      public String executeUdp( int aP0_TTBUS_Id ,
                                short aP1_TTBUS_CodPosicion ,
                                out String aP2_TTBUS_DesPosicion ,
                                out String aP3_SEC_CRE )
      {
         this.AV12TTBUS_Id = aP0_TTBUS_Id;
         this.AV10TTBUS_CodPosicion = aP1_TTBUS_CodPosicion;
         this.AV11TTBUS_DesPosicion = "" ;
         this.AV8SEC_CRE = "" ;
         this.AV9SEC_DRE = "" ;
         initialize();
         executePrivate();
         aP2_TTBUS_DesPosicion=this.AV11TTBUS_DesPosicion;
         aP3_SEC_CRE=this.AV8SEC_CRE;
         aP4_SEC_DRE=this.AV9SEC_DRE;
         return AV9SEC_DRE ;
      }

      public void executeSubmit( int aP0_TTBUS_Id ,
                                 short aP1_TTBUS_CodPosicion ,
                                 out String aP2_TTBUS_DesPosicion ,
                                 out String aP3_SEC_CRE ,
                                 out String aP4_SEC_DRE )
      {
         pttbus000_5 objpttbus000_5;
         objpttbus000_5 = new pttbus000_5();
         objpttbus000_5.AV12TTBUS_Id = aP0_TTBUS_Id;
         objpttbus000_5.AV10TTBUS_CodPosicion = aP1_TTBUS_CodPosicion;
         objpttbus000_5.AV11TTBUS_DesPosicion = "" ;
         objpttbus000_5.AV8SEC_CRE = "" ;
         objpttbus000_5.AV9SEC_DRE = "" ;
         objpttbus000_5.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpttbus000_5.executePrivateCatch ));
         aP2_TTBUS_DesPosicion=this.AV11TTBUS_DesPosicion;
         aP3_SEC_CRE=this.AV8SEC_CRE;
         aP4_SEC_DRE=this.AV9SEC_DRE;
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
         if ( AV10TTBUS_CodPosicion != 999 )
         {
            /* Using cursor P00062 */
            pr_default.execute(0, new Object[] {AV10TTBUS_CodPosicion});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A33TTBUS7_Pos = P00062_A33TTBUS7_Pos[0] ;
               A34TTBUS7_Des = P00062_A34TTBUS7_Des[0] ;
               n34TTBUS7_Des = P00062_n34TTBUS7_Des[0] ;
               A35TTBUS7_CodResp = P00062_A35TTBUS7_CodResp[0] ;
               A36TTBUS7_DesResp = P00062_A36TTBUS7_DesResp[0] ;
               n36TTBUS7_DesResp = P00062_n36TTBUS7_DesResp[0] ;
               A34TTBUS7_Des = P00062_A34TTBUS7_Des[0] ;
               n34TTBUS7_Des = P00062_n34TTBUS7_Des[0] ;
               A36TTBUS7_DesResp = P00062_A36TTBUS7_DesResp[0] ;
               n36TTBUS7_DesResp = P00062_n36TTBUS7_DesResp[0] ;
               AV11TTBUS_DesPosicion = A34TTBUS7_Des ;
               AV8SEC_CRE = A35TTBUS7_CodResp ;
               AV9SEC_DRE = A36TTBUS7_DesResp ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
         }
         else
         {
            /* Using cursor P00063 */
            pr_default.execute(1, new Object[] {AV12TTBUS_Id});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A26TTBUS2_EstadoEnvio = P00063_A26TTBUS2_EstadoEnvio[0] ;
               A22TTBUS2_IdBien = P00063_A22TTBUS2_IdBien[0] ;
               A24TTBUS2_RespDesde = P00063_A24TTBUS2_RespDesde[0] ;
               A25TTBUS2_RespHacia = P00063_A25TTBUS2_RespHacia[0] ;
               A52TTBUS2_IdMovimiento = P00063_A52TTBUS2_IdMovimiento[0] ;
               AV13TTBUS2_RespDesde = A24TTBUS2_RespDesde ;
               AV14TTBUS2_RespHacia = A25TTBUS2_RespHacia ;
               /* Execute user subroutine: S1122 */
               S1122 ();
               if ( returnInSub )
               {
                  pr_default.close(1);
                  this.cleanup();
                  if (true) return;
               }
               pr_default.readNext(1);
            }
            pr_default.close(1);
            AV9SEC_DRE = StringUtil.Trim( AV15dUSU_DES) + " Y " + StringUtil.Trim( AV16hUSU_DES) ;
            AV11TTBUS_DesPosicion = "SIN ASIGNAR POR CAMBIO DE POSICIÓN" ;
         }
         this.cleanup();
      }

      protected void S1122( )
      {
         /* 'RESPONSABLES' Routine */
         /* Using cursor P00064 */
         pr_default.execute(2, new Object[] {AV13TTBUS2_RespDesde});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A6USU_COD = P00064_A6USU_COD[0] ;
            A7USU_DES = P00064_A7USU_DES[0] ;
            AV15dUSU_DES = A7USU_DES ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(2);
         /* Using cursor P00065 */
         pr_default.execute(3, new Object[] {AV14TTBUS2_RespHacia});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A6USU_COD = P00065_A6USU_COD[0] ;
            A7USU_DES = P00065_A7USU_DES[0] ;
            AV16hUSU_DES = A7USU_DES ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(3);
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
         P00062_A33TTBUS7_Pos = new short[1] ;
         P00062_A34TTBUS7_Des = new String[] {""} ;
         P00062_n34TTBUS7_Des = new bool[] {false} ;
         P00062_A35TTBUS7_CodResp = new String[] {""} ;
         P00062_A36TTBUS7_DesResp = new String[] {""} ;
         P00062_n36TTBUS7_DesResp = new bool[] {false} ;
         A34TTBUS7_Des = "" ;
         A35TTBUS7_CodResp = "" ;
         A36TTBUS7_DesResp = "" ;
         P00063_A26TTBUS2_EstadoEnvio = new short[1] ;
         P00063_A22TTBUS2_IdBien = new int[1] ;
         P00063_A24TTBUS2_RespDesde = new String[] {""} ;
         P00063_A25TTBUS2_RespHacia = new String[] {""} ;
         P00063_A52TTBUS2_IdMovimiento = new long[1] ;
         A24TTBUS2_RespDesde = "" ;
         A25TTBUS2_RespHacia = "" ;
         AV13TTBUS2_RespDesde = "" ;
         AV14TTBUS2_RespHacia = "" ;
         AV15dUSU_DES = "" ;
         AV16hUSU_DES = "" ;
         P00064_A6USU_COD = new String[] {""} ;
         P00064_A7USU_DES = new String[] {""} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         P00065_A6USU_COD = new String[] {""} ;
         P00065_A7USU_DES = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pttbus000_5__default(),
            new Object[][] {
                new Object[] {
               P00062_A33TTBUS7_Pos, P00062_A34TTBUS7_Des, P00062_n34TTBUS7_Des, P00062_A35TTBUS7_CodResp, P00062_A36TTBUS7_DesResp, P00062_n36TTBUS7_DesResp
               }
               , new Object[] {
               P00063_A26TTBUS2_EstadoEnvio, P00063_A22TTBUS2_IdBien, P00063_A24TTBUS2_RespDesde, P00063_A25TTBUS2_RespHacia, P00063_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P00064_A6USU_COD, P00064_A7USU_DES
               }
               , new Object[] {
               P00065_A6USU_COD, P00065_A7USU_DES
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV10TTBUS_CodPosicion ;
      private short A33TTBUS7_Pos ;
      private short A26TTBUS2_EstadoEnvio ;
      private int AV12TTBUS_Id ;
      private int A22TTBUS2_IdBien ;
      private long A52TTBUS2_IdMovimiento ;
      private String AV9SEC_DRE ;
      private String scmdbuf ;
      private String A34TTBUS7_Des ;
      private String A35TTBUS7_CodResp ;
      private String A36TTBUS7_DesResp ;
      private String AV11TTBUS_DesPosicion ;
      private String AV8SEC_CRE ;
      private String A24TTBUS2_RespDesde ;
      private String A25TTBUS2_RespHacia ;
      private String AV13TTBUS2_RespDesde ;
      private String AV14TTBUS2_RespHacia ;
      private String AV15dUSU_DES ;
      private String AV16hUSU_DES ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private bool n34TTBUS7_Des ;
      private bool n36TTBUS7_DesResp ;
      private bool returnInSub ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00062_A33TTBUS7_Pos ;
      private String[] P00062_A34TTBUS7_Des ;
      private bool[] P00062_n34TTBUS7_Des ;
      private String[] P00062_A35TTBUS7_CodResp ;
      private String[] P00062_A36TTBUS7_DesResp ;
      private bool[] P00062_n36TTBUS7_DesResp ;
      private short[] P00063_A26TTBUS2_EstadoEnvio ;
      private int[] P00063_A22TTBUS2_IdBien ;
      private String[] P00063_A24TTBUS2_RespDesde ;
      private String[] P00063_A25TTBUS2_RespHacia ;
      private long[] P00063_A52TTBUS2_IdMovimiento ;
      private String[] P00064_A6USU_COD ;
      private String[] P00064_A7USU_DES ;
      private String[] P00065_A6USU_COD ;
      private String[] P00065_A7USU_DES ;
      private String aP2_TTBUS_DesPosicion ;
      private String aP3_SEC_CRE ;
      private String aP4_SEC_DRE ;
   }

   public class pttbus000_5__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00062 ;
          prmP00062 = new Object[] {
          new Object[] {"@AV10TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP00063 ;
          prmP00063 = new Object[] {
          new Object[] {"@AV12TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP00064 ;
          prmP00064 = new Object[] {
          new Object[] {"@AV13TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmP00065 ;
          prmP00065 = new Object[] {
          new Object[] {"@AV14TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00062", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des, T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T3.[USU_DES] AS TTBUS7_DesResp FROM (([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) INNER JOIN [SEG002] T3 WITH (NOLOCK) ON T3.[USU_COD] = T1.[TTBUS7_CodResp]) WHERE T1.[TTBUS7_Pos] = @AV10TTBUS_CodPosicion ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00062,1,0,false,true )
             ,new CursorDef("P00063", "SELECT [TTBUS2_EstadoEnvio], [TTBUS2_IdBien], [TTBUS2_RespDesde], [TTBUS2_RespHacia], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdBien] = @AV12TTBUS_Id) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00063,100,0,true,false )
             ,new CursorDef("P00064", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV13TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00064,1,0,false,true )
             ,new CursorDef("P00065", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV14TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00065,1,0,false,true )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 16) ;
                ((String[]) buf[4])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 15) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
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
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
