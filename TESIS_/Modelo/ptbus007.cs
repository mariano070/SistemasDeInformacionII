/*
               File: PTBUS007
        Description: Filtra usuario con acceso a bien de uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:46:9.19
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
   public class ptbus007 : GXProcedure
   {
      public ptbus007( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus007( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref short aP0_band ,
                           int aP1_TTBUS_Id ,
                           String aP2_USUARIO )
      {
         this.AV9band = aP0_band;
         this.AV10TTBUS_Id = aP1_TTBUS_Id;
         this.AV8USUARIO = aP2_USUARIO;
         initialize();
         executePrivate();
         aP0_band=this.AV9band;
      }

      public void executeSubmit( ref short aP0_band ,
                                 int aP1_TTBUS_Id ,
                                 String aP2_USUARIO )
      {
         ptbus007 objptbus007;
         objptbus007 = new ptbus007();
         objptbus007.AV9band = aP0_band;
         objptbus007.AV10TTBUS_Id = aP1_TTBUS_Id;
         objptbus007.AV8USUARIO = aP2_USUARIO;
         objptbus007.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus007.executePrivateCatch ));
         aP0_band=this.AV9band;
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
         if ( StringUtil.StrCmp(AV8USUARIO, "SUPERVISOR") == 0 )
         {
            AV9band = 1 ;
         }
         if ( AV9band == 0 )
         {
            /* Using cursor P000J2 */
            pr_default.execute(0, new Object[] {AV8USUARIO});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A40TTBUS8_CodUsuario = P000J2_A40TTBUS8_CodUsuario[0] ;
               AV9band = 1 ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
         }
         if ( AV9band == 0 )
         {
            /* Using cursor P000J3 */
            pr_default.execute(1, new Object[] {AV10TTBUS_Id});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A35TTBUS7_CodResp = P000J3_A35TTBUS7_CodResp[0] ;
               n35TTBUS7_CodResp = P000J3_n35TTBUS7_CodResp[0] ;
               A11TTBUS_Id = P000J3_A11TTBUS_Id[0] ;
               A23TTBUS_Estado = P000J3_A23TTBUS_Estado[0] ;
               A37TTBUS_CodPosicion = P000J3_A37TTBUS_CodPosicion[0] ;
               A35TTBUS7_CodResp = P000J3_A35TTBUS7_CodResp[0] ;
               n35TTBUS7_CodResp = P000J3_n35TTBUS7_CodResp[0] ;
               if ( A23TTBUS_Estado == 1 )
               {
                  AV11TTBUS_CodPosicion = A37TTBUS_CodPosicion ;
                  /* Using cursor P000J4 */
                  pr_default.execute(2, new Object[] {AV11TTBUS_CodPosicion});
                  while ( (pr_default.getStatus(2) != 101) )
                  {
                     A33TTBUS7_Pos = P000J4_A33TTBUS7_Pos[0] ;
                     if ( StringUtil.StrCmp(A35TTBUS7_CodResp, AV8USUARIO) == 0 )
                     {
                        AV9band = 1 ;
                     }
                     /* Exiting from a For First loop. */
                     if (true) break;
                  }
                  pr_default.close(2);
                  if ( AV9band == 0 )
                  {
                     /* Using cursor P000J5 */
                     pr_default.execute(3, new Object[] {AV11TTBUS_CodPosicion, AV8USUARIO});
                     while ( (pr_default.getStatus(3) != 101) )
                     {
                        A39TTBUS7_CodUsuario = P000J5_A39TTBUS7_CodUsuario[0] ;
                        A33TTBUS7_Pos = P000J5_A33TTBUS7_Pos[0] ;
                        AV9band = 1 ;
                        /* Exiting from a For First loop. */
                        if (true) break;
                     }
                     pr_default.close(3);
                  }
               }
               else
               {
                  /* Using cursor P000J6 */
                  pr_default.execute(4, new Object[] {AV10TTBUS_Id});
                  while ( (pr_default.getStatus(4) != 101) )
                  {
                     A26TTBUS2_EstadoEnvio = P000J6_A26TTBUS2_EstadoEnvio[0] ;
                     A22TTBUS2_IdBien = P000J6_A22TTBUS2_IdBien[0] ;
                     A24TTBUS2_RespDesde = P000J6_A24TTBUS2_RespDesde[0] ;
                     A25TTBUS2_RespHacia = P000J6_A25TTBUS2_RespHacia[0] ;
                     A52TTBUS2_IdMovimiento = P000J6_A52TTBUS2_IdMovimiento[0] ;
                     if ( StringUtil.StrCmp(A24TTBUS2_RespDesde, AV8USUARIO) == 0 )
                     {
                        AV9band = 1 ;
                     }
                     if ( StringUtil.StrCmp(A25TTBUS2_RespHacia, AV8USUARIO) == 0 )
                     {
                        AV9band = 1 ;
                     }
                     pr_default.readNext(4);
                  }
                  pr_default.close(4);
               }
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
         }
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
         P000J2_A40TTBUS8_CodUsuario = new String[] {""} ;
         A40TTBUS8_CodUsuario = "" ;
         P000J3_A35TTBUS7_CodResp = new String[] {""} ;
         P000J3_n35TTBUS7_CodResp = new bool[] {false} ;
         P000J3_A11TTBUS_Id = new int[1] ;
         P000J3_A23TTBUS_Estado = new short[1] ;
         P000J3_A37TTBUS_CodPosicion = new short[1] ;
         A35TTBUS7_CodResp = "" ;
         P000J4_A33TTBUS7_Pos = new short[1] ;
         P000J5_A39TTBUS7_CodUsuario = new String[] {""} ;
         P000J5_A33TTBUS7_Pos = new short[1] ;
         A39TTBUS7_CodUsuario = "" ;
         P000J6_A26TTBUS2_EstadoEnvio = new short[1] ;
         P000J6_A22TTBUS2_IdBien = new int[1] ;
         P000J6_A24TTBUS2_RespDesde = new String[] {""} ;
         P000J6_A25TTBUS2_RespHacia = new String[] {""} ;
         P000J6_A52TTBUS2_IdMovimiento = new long[1] ;
         A24TTBUS2_RespDesde = "" ;
         A25TTBUS2_RespHacia = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus007__default(),
            new Object[][] {
                new Object[] {
               P000J2_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               P000J3_A35TTBUS7_CodResp, P000J3_n35TTBUS7_CodResp, P000J3_A11TTBUS_Id, P000J3_A23TTBUS_Estado, P000J3_A37TTBUS_CodPosicion
               }
               , new Object[] {
               P000J4_A33TTBUS7_Pos
               }
               , new Object[] {
               P000J5_A39TTBUS7_CodUsuario, P000J5_A33TTBUS7_Pos
               }
               , new Object[] {
               P000J6_A26TTBUS2_EstadoEnvio, P000J6_A22TTBUS2_IdBien, P000J6_A24TTBUS2_RespDesde, P000J6_A25TTBUS2_RespHacia, P000J6_A52TTBUS2_IdMovimiento
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV9band ;
      private short A23TTBUS_Estado ;
      private short A37TTBUS_CodPosicion ;
      private short AV11TTBUS_CodPosicion ;
      private short A33TTBUS7_Pos ;
      private short A26TTBUS2_EstadoEnvio ;
      private int AV10TTBUS_Id ;
      private int A11TTBUS_Id ;
      private int A22TTBUS2_IdBien ;
      private long A52TTBUS2_IdMovimiento ;
      private String AV8USUARIO ;
      private String scmdbuf ;
      private String A40TTBUS8_CodUsuario ;
      private String A35TTBUS7_CodResp ;
      private String A39TTBUS7_CodUsuario ;
      private String A24TTBUS2_RespDesde ;
      private String A25TTBUS2_RespHacia ;
      private bool n35TTBUS7_CodResp ;
      private IGxDataStore dsDefault ;
      private short aP0_band ;
      private IDataStoreProvider pr_default ;
      private String[] P000J2_A40TTBUS8_CodUsuario ;
      private String[] P000J3_A35TTBUS7_CodResp ;
      private bool[] P000J3_n35TTBUS7_CodResp ;
      private int[] P000J3_A11TTBUS_Id ;
      private short[] P000J3_A23TTBUS_Estado ;
      private short[] P000J3_A37TTBUS_CodPosicion ;
      private short[] P000J4_A33TTBUS7_Pos ;
      private String[] P000J5_A39TTBUS7_CodUsuario ;
      private short[] P000J5_A33TTBUS7_Pos ;
      private short[] P000J6_A26TTBUS2_EstadoEnvio ;
      private int[] P000J6_A22TTBUS2_IdBien ;
      private String[] P000J6_A24TTBUS2_RespDesde ;
      private String[] P000J6_A25TTBUS2_RespHacia ;
      private long[] P000J6_A52TTBUS2_IdMovimiento ;
   }

   public class ptbus007__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000J2 ;
          prmP000J2 = new Object[] {
          new Object[] {"@AV8USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmP000J3 ;
          prmP000J3 = new Object[] {
          new Object[] {"@AV10TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP000J4 ;
          prmP000J4 = new Object[] {
          new Object[] {"@AV11TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP000J5 ;
          prmP000J5 = new Object[] {
          new Object[] {"@AV11TTBUS_CodPosicion",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV8USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmP000J6 ;
          prmP000J6 = new Object[] {
          new Object[] {"@AV10TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000J2", "SELECT [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @AV8USUARIO ORDER BY [TTBUS8_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J2,1,0,false,true )
             ,new CursorDef("P000J3", "SELECT T2.[TTBUS7_CodResp], T1.[TTBUS_Id], T1.[TTBUS_Estado], T1.[TTBUS_CodPosicion] AS TTBUS_CodPosicion FROM ([TTBUS000] T1 WITH (NOLOCK) INNER JOIN [TTBUS007] T2 WITH (NOLOCK) ON T2.[TTBUS7_Pos] = T1.[TTBUS_CodPosicion]) WHERE T1.[TTBUS_Id] = @AV10TTBUS_Id ORDER BY T1.[TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J3,1,0,true,true )
             ,new CursorDef("P000J4", "SELECT [TTBUS7_Pos] FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV11TTBUS_CodPosicion ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J4,1,0,false,true )
             ,new CursorDef("P000J5", "SELECT [TTBUS7_CodUsuario], [TTBUS7_Pos] FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV11TTBUS_CodPosicion and [TTBUS7_CodUsuario] = @AV8USUARIO ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J5,1,0,false,true )
             ,new CursorDef("P000J6", "SELECT [TTBUS2_EstadoEnvio], [TTBUS2_IdBien], [TTBUS2_RespDesde], [TTBUS2_RespHacia], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdBien] = @AV10TTBUS_Id) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J6,100,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 15) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
