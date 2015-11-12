/*
               File: PTBUS025
        Description: Restriccion a Usuarios Sin Responsabilidad
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:28:57.68
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
   public class ptbus025 : GXProcedure
   {
      public ptbus025( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus025( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_USUARIO ,
                           out short aP1_usu_permiso )
      {
         this.AV9USUARIO = aP0_USUARIO;
         this.AV8usu_permiso = 0 ;
         initialize();
         executePrivate();
         aP1_usu_permiso=this.AV8usu_permiso;
      }

      public short executeUdp( String aP0_USUARIO )
      {
         this.AV9USUARIO = aP0_USUARIO;
         this.AV8usu_permiso = 0 ;
         initialize();
         executePrivate();
         aP1_usu_permiso=this.AV8usu_permiso;
         return AV8usu_permiso ;
      }

      public void executeSubmit( String aP0_USUARIO ,
                                 out short aP1_usu_permiso )
      {
         ptbus025 objptbus025;
         objptbus025 = new ptbus025();
         objptbus025.AV9USUARIO = aP0_USUARIO;
         objptbus025.AV8usu_permiso = 0 ;
         objptbus025.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus025.executePrivateCatch ));
         aP1_usu_permiso=this.AV8usu_permiso;
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
         AV8usu_permiso = 1 ;
         if ( StringUtil.StrCmp(AV9USUARIO, "SUPERVISOR") == 0 )
         {
            AV8usu_permiso = 0 ;
         }
         if ( AV8usu_permiso == 1 )
         {
            /* Using cursor P000K2 */
            pr_default.execute(0, new Object[] {AV9USUARIO});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A40TTBUS8_CodUsuario = P000K2_A40TTBUS8_CodUsuario[0] ;
               AV8usu_permiso = 0 ;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
         }
         if ( AV8usu_permiso == 1 )
         {
            /* Using cursor P000K3 */
            pr_default.execute(1, new Object[] {AV9USUARIO});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A35TTBUS7_CodResp = P000K3_A35TTBUS7_CodResp[0] ;
               A33TTBUS7_Pos = P000K3_A33TTBUS7_Pos[0] ;
               AV8usu_permiso = 0 ;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(1);
            }
            pr_default.close(1);
         }
         if ( AV8usu_permiso == 1 )
         {
            /* Using cursor P000K4 */
            pr_default.execute(2, new Object[] {AV9USUARIO});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A39TTBUS7_CodUsuario = P000K4_A39TTBUS7_CodUsuario[0] ;
               A51TTBUS7_RespAux = P000K4_A51TTBUS7_RespAux[0] ;
               A33TTBUS7_Pos = P000K4_A33TTBUS7_Pos[0] ;
               if ( A51TTBUS7_RespAux == 1 )
               {
                  AV8usu_permiso = 0 ;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               pr_default.readNext(2);
            }
            pr_default.close(2);
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
         P000K2_A40TTBUS8_CodUsuario = new String[] {""} ;
         A40TTBUS8_CodUsuario = "" ;
         P000K3_A35TTBUS7_CodResp = new String[] {""} ;
         P000K3_A33TTBUS7_Pos = new short[1] ;
         A35TTBUS7_CodResp = "" ;
         P000K4_A39TTBUS7_CodUsuario = new String[] {""} ;
         P000K4_A51TTBUS7_RespAux = new short[1] ;
         P000K4_A33TTBUS7_Pos = new short[1] ;
         A39TTBUS7_CodUsuario = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus025__default(),
            new Object[][] {
                new Object[] {
               P000K2_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               P000K3_A35TTBUS7_CodResp, P000K3_A33TTBUS7_Pos
               }
               , new Object[] {
               P000K4_A39TTBUS7_CodUsuario, P000K4_A51TTBUS7_RespAux, P000K4_A33TTBUS7_Pos
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV8usu_permiso ;
      private short A33TTBUS7_Pos ;
      private short A51TTBUS7_RespAux ;
      private String AV9USUARIO ;
      private String scmdbuf ;
      private String A40TTBUS8_CodUsuario ;
      private String A35TTBUS7_CodResp ;
      private String A39TTBUS7_CodUsuario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000K2_A40TTBUS8_CodUsuario ;
      private String[] P000K3_A35TTBUS7_CodResp ;
      private short[] P000K3_A33TTBUS7_Pos ;
      private String[] P000K4_A39TTBUS7_CodUsuario ;
      private short[] P000K4_A51TTBUS7_RespAux ;
      private short[] P000K4_A33TTBUS7_Pos ;
      private short aP1_usu_permiso ;
   }

   public class ptbus025__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000K2 ;
          prmP000K2 = new Object[] {
          new Object[] {"@AV9USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmP000K3 ;
          prmP000K3 = new Object[] {
          new Object[] {"@AV9USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmP000K4 ;
          prmP000K4 = new Object[] {
          new Object[] {"@AV9USUARIO",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000K2", "SELECT TOP 1 [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @AV9USUARIO ORDER BY [TTBUS8_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000K2,1,0,false,true )
             ,new CursorDef("P000K3", "SELECT TOP 1 [TTBUS7_CodResp], [TTBUS7_Pos] FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_CodResp] = @AV9USUARIO ORDER BY [TTBUS7_CodResp] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000K3,1,0,false,true )
             ,new CursorDef("P000K4", "SELECT [TTBUS7_CodUsuario], [TTBUS7_RespAux], [TTBUS7_Pos] FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_CodUsuario] = @AV9USUARIO ORDER BY [TTBUS7_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000K4,100,0,false,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 2 :
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
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
