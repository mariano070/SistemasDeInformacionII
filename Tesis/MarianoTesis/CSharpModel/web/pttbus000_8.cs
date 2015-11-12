/*
               File: PTTBUS000_8
        Description: Controla que la posición ingresada a mano no sea inválida
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:28:58.54
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
   public class pttbus000_8 : GXProcedure
   {
      public pttbus000_8( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pttbus000_8( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( short aP0_TTBUS_CodPosicion ,
                           String aP1_Modo ,
                           String aP2_USUARIO ,
                           out short aP3_cod_error ,
                           out String aP4_mje_error )
      {
         this.AV10TTBUS_CodPosicion = aP0_TTBUS_CodPosicion;
         this.AV9Modo = aP1_Modo;
         this.AV8USUARIO = aP2_USUARIO;
         this.AV11cod_error = 0 ;
         this.AV13mje_error = "" ;
         initialize();
         executePrivate();
         aP3_cod_error=this.AV11cod_error;
         aP4_mje_error=this.AV13mje_error;
      }

      public String executeUdp( short aP0_TTBUS_CodPosicion ,
                                String aP1_Modo ,
                                String aP2_USUARIO ,
                                out short aP3_cod_error )
      {
         this.AV10TTBUS_CodPosicion = aP0_TTBUS_CodPosicion;
         this.AV9Modo = aP1_Modo;
         this.AV8USUARIO = aP2_USUARIO;
         this.AV11cod_error = 0 ;
         this.AV13mje_error = "" ;
         initialize();
         executePrivate();
         aP3_cod_error=this.AV11cod_error;
         aP4_mje_error=this.AV13mje_error;
         return AV13mje_error ;
      }

      public void executeSubmit( short aP0_TTBUS_CodPosicion ,
                                 String aP1_Modo ,
                                 String aP2_USUARIO ,
                                 out short aP3_cod_error ,
                                 out String aP4_mje_error )
      {
         pttbus000_8 objpttbus000_8;
         objpttbus000_8 = new pttbus000_8();
         objpttbus000_8.AV10TTBUS_CodPosicion = aP0_TTBUS_CodPosicion;
         objpttbus000_8.AV9Modo = aP1_Modo;
         objpttbus000_8.AV8USUARIO = aP2_USUARIO;
         objpttbus000_8.AV11cod_error = 0 ;
         objpttbus000_8.AV13mje_error = "" ;
         objpttbus000_8.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpttbus000_8.executePrivateCatch ));
         aP3_cod_error=this.AV11cod_error;
         aP4_mje_error=this.AV13mje_error;
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
         AV11cod_error = 1 ;
         /* Using cursor P00072 */
         pr_default.execute(0, new Object[] {AV10TTBUS_CodPosicion});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A33TTBUS7_Pos = P00072_A33TTBUS7_Pos[0] ;
            AV11cod_error = 0 ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         if ( AV11cod_error == 1 )
         {
            AV13mje_error = "LA POSICIÓN INGRESADA NO EXITE." ;
         }
         else
         {
            if ( StringUtil.StrCmp(AV9Modo, "INS") == 0 )
            {
               AV11cod_error = 1 ;
               if ( StringUtil.StrCmp(AV8USUARIO, "SUPERVISOR") == 0 )
               {
                  AV11cod_error = 0 ;
               }
               if ( AV11cod_error == 1 )
               {
                  /* Using cursor P00073 */
                  pr_default.execute(1, new Object[] {AV8USUARIO});
                  while ( (pr_default.getStatus(1) != 101) )
                  {
                     A40TTBUS8_CodUsuario = P00073_A40TTBUS8_CodUsuario[0] ;
                     AV11cod_error = 0 ;
                     /* Exiting from a For First loop. */
                     if (true) break;
                  }
                  pr_default.close(1);
               }
               if ( AV11cod_error == 1 )
               {
                  /* Using cursor P00074 */
                  pr_default.execute(2, new Object[] {AV10TTBUS_CodPosicion});
                  while ( (pr_default.getStatus(2) != 101) )
                  {
                     A33TTBUS7_Pos = P00074_A33TTBUS7_Pos[0] ;
                     A35TTBUS7_CodResp = P00074_A35TTBUS7_CodResp[0] ;
                     if ( StringUtil.StrCmp(A35TTBUS7_CodResp, AV8USUARIO) == 0 )
                     {
                        AV11cod_error = 0 ;
                     }
                     else
                     {
                        /* Using cursor P00075 */
                        pr_default.execute(3, new Object[] {AV10TTBUS_CodPosicion, AV8USUARIO});
                        while ( (pr_default.getStatus(3) != 101) )
                        {
                           A39TTBUS7_CodUsuario = P00075_A39TTBUS7_CodUsuario[0] ;
                           A33TTBUS7_Pos = P00075_A33TTBUS7_Pos[0] ;
                           A51TTBUS7_RespAux = P00075_A51TTBUS7_RespAux[0] ;
                           if ( A51TTBUS7_RespAux == 1 )
                           {
                              AV11cod_error = 0 ;
                           }
                           /* Exiting from a For First loop. */
                           if (true) break;
                        }
                        pr_default.close(3);
                     }
                     /* Exiting from a For First loop. */
                     if (true) break;
                  }
                  pr_default.close(2);
               }
               if ( AV11cod_error == 1 )
               {
                  AV13mje_error = "NO TIENE PERMISOS PARA DAR DE ALTA UN BIEN PARA EN ESTA POSICIÓN." ;
               }
            }
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
         P00072_A33TTBUS7_Pos = new short[1] ;
         P00073_A40TTBUS8_CodUsuario = new String[] {""} ;
         A40TTBUS8_CodUsuario = "" ;
         P00074_A33TTBUS7_Pos = new short[1] ;
         P00074_A35TTBUS7_CodResp = new String[] {""} ;
         A35TTBUS7_CodResp = "" ;
         P00075_A39TTBUS7_CodUsuario = new String[] {""} ;
         P00075_A33TTBUS7_Pos = new short[1] ;
         P00075_A51TTBUS7_RespAux = new short[1] ;
         A39TTBUS7_CodUsuario = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pttbus000_8__default(),
            new Object[][] {
                new Object[] {
               P00072_A33TTBUS7_Pos
               }
               , new Object[] {
               P00073_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               P00074_A33TTBUS7_Pos, P00074_A35TTBUS7_CodResp
               }
               , new Object[] {
               P00075_A39TTBUS7_CodUsuario, P00075_A33TTBUS7_Pos, P00075_A51TTBUS7_RespAux
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV10TTBUS_CodPosicion ;
      private short AV11cod_error ;
      private short A33TTBUS7_Pos ;
      private short A51TTBUS7_RespAux ;
      private String AV9Modo ;
      private String AV8USUARIO ;
      private String AV13mje_error ;
      private String scmdbuf ;
      private String A40TTBUS8_CodUsuario ;
      private String A35TTBUS7_CodResp ;
      private String A39TTBUS7_CodUsuario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00072_A33TTBUS7_Pos ;
      private String[] P00073_A40TTBUS8_CodUsuario ;
      private short[] P00074_A33TTBUS7_Pos ;
      private String[] P00074_A35TTBUS7_CodResp ;
      private String[] P00075_A39TTBUS7_CodUsuario ;
      private short[] P00075_A33TTBUS7_Pos ;
      private short[] P00075_A51TTBUS7_RespAux ;
      private short aP3_cod_error ;
      private String aP4_mje_error ;
   }

   public class pttbus000_8__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00072 ;
          prmP00072 = new Object[] {
          new Object[] {"@AV10TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP00073 ;
          prmP00073 = new Object[] {
          new Object[] {"@AV8USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmP00074 ;
          prmP00074 = new Object[] {
          new Object[] {"@AV10TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP00075 ;
          prmP00075 = new Object[] {
          new Object[] {"@AV10TTBUS_CodPosicion",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV8USUARIO",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00072", "SELECT TOP 1 [TTBUS7_Pos] FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV10TTBUS_CodPosicion ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00072,1,0,false,true )
             ,new CursorDef("P00073", "SELECT [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @AV8USUARIO ORDER BY [TTBUS8_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00073,1,0,false,true )
             ,new CursorDef("P00074", "SELECT [TTBUS7_Pos], [TTBUS7_CodResp] FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV10TTBUS_CodPosicion ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00074,1,0,true,true )
             ,new CursorDef("P00075", "SELECT [TTBUS7_CodUsuario], [TTBUS7_Pos], [TTBUS7_RespAux] FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV10TTBUS_CodPosicion and [TTBUS7_CodUsuario] = @AV8USUARIO ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00075,1,0,false,true )
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
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
