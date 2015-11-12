/*
               File: PTTBUS000_6
        Description: Validaciones TTBUS000 (autoridades para cambiar posiciones)
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:28:58.95
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
   public class pttbus000_6 : GXProcedure
   {
      public pttbus000_6( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pttbus000_6( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( short aP0_TTBUS_CodPosicion ,
                           ref short aP1_band ,
                           String aP2_USUARIO )
      {
         this.AV8TTBUS_CodPosicion = aP0_TTBUS_CodPosicion;
         this.AV10band = aP1_band;
         this.AV9USUARIO = aP2_USUARIO;
         initialize();
         executePrivate();
         aP1_band=this.AV10band;
      }

      public void executeSubmit( short aP0_TTBUS_CodPosicion ,
                                 ref short aP1_band ,
                                 String aP2_USUARIO )
      {
         pttbus000_6 objpttbus000_6;
         objpttbus000_6 = new pttbus000_6();
         objpttbus000_6.AV8TTBUS_CodPosicion = aP0_TTBUS_CodPosicion;
         objpttbus000_6.AV10band = aP1_band;
         objpttbus000_6.AV9USUARIO = aP2_USUARIO;
         objpttbus000_6.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpttbus000_6.executePrivateCatch ));
         aP1_band=this.AV10band;
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
         /* Using cursor P000A2 */
         pr_default.execute(0, new Object[] {AV8TTBUS_CodPosicion});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A33TTBUS7_Pos = P000A2_A33TTBUS7_Pos[0] ;
            A35TTBUS7_CodResp = P000A2_A35TTBUS7_CodResp[0] ;
            if ( StringUtil.StrCmp(A35TTBUS7_CodResp, AV9USUARIO) == 0 )
            {
               AV10band = 1 ;
            }
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         if ( AV10band == 0 )
         {
            /* Using cursor P000A3 */
            pr_default.execute(1, new Object[] {AV8TTBUS_CodPosicion, AV9USUARIO});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A39TTBUS7_CodUsuario = P000A3_A39TTBUS7_CodUsuario[0] ;
               A33TTBUS7_Pos = P000A3_A33TTBUS7_Pos[0] ;
               A51TTBUS7_RespAux = P000A3_A51TTBUS7_RespAux[0] ;
               if ( A51TTBUS7_RespAux == 1 )
               {
                  AV10band = 1 ;
               }
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
         }
         if ( AV10band == 0 )
         {
            /* Using cursor P000A4 */
            pr_default.execute(2, new Object[] {AV9USUARIO});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A40TTBUS8_CodUsuario = P000A4_A40TTBUS8_CodUsuario[0] ;
               AV10band = 1 ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
         }
         if ( AV10band == 0 )
         {
            if ( StringUtil.StrCmp(AV9USUARIO, "SUPERVISOR") == 0 )
            {
               AV10band = 1 ;
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
         P000A2_A33TTBUS7_Pos = new short[1] ;
         P000A2_A35TTBUS7_CodResp = new String[] {""} ;
         A35TTBUS7_CodResp = "" ;
         P000A3_A39TTBUS7_CodUsuario = new String[] {""} ;
         P000A3_A33TTBUS7_Pos = new short[1] ;
         P000A3_A51TTBUS7_RespAux = new short[1] ;
         A39TTBUS7_CodUsuario = "" ;
         P000A4_A40TTBUS8_CodUsuario = new String[] {""} ;
         A40TTBUS8_CodUsuario = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pttbus000_6__default(),
            new Object[][] {
                new Object[] {
               P000A2_A33TTBUS7_Pos, P000A2_A35TTBUS7_CodResp
               }
               , new Object[] {
               P000A3_A39TTBUS7_CodUsuario, P000A3_A33TTBUS7_Pos, P000A3_A51TTBUS7_RespAux
               }
               , new Object[] {
               P000A4_A40TTBUS8_CodUsuario
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV8TTBUS_CodPosicion ;
      private short AV10band ;
      private short A33TTBUS7_Pos ;
      private short A51TTBUS7_RespAux ;
      private String AV9USUARIO ;
      private String scmdbuf ;
      private String A35TTBUS7_CodResp ;
      private String A39TTBUS7_CodUsuario ;
      private String A40TTBUS8_CodUsuario ;
      private IGxDataStore dsDefault ;
      private short aP1_band ;
      private IDataStoreProvider pr_default ;
      private short[] P000A2_A33TTBUS7_Pos ;
      private String[] P000A2_A35TTBUS7_CodResp ;
      private String[] P000A3_A39TTBUS7_CodUsuario ;
      private short[] P000A3_A33TTBUS7_Pos ;
      private short[] P000A3_A51TTBUS7_RespAux ;
      private String[] P000A4_A40TTBUS8_CodUsuario ;
   }

   public class pttbus000_6__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000A2 ;
          prmP000A2 = new Object[] {
          new Object[] {"@AV8TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP000A3 ;
          prmP000A3 = new Object[] {
          new Object[] {"@AV8TTBUS_CodPosicion",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV9USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmP000A4 ;
          prmP000A4 = new Object[] {
          new Object[] {"@AV9USUARIO",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000A2", "SELECT [TTBUS7_Pos], [TTBUS7_CodResp] FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV8TTBUS_CodPosicion ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000A2,1,0,false,true )
             ,new CursorDef("P000A3", "SELECT [TTBUS7_CodUsuario], [TTBUS7_Pos], [TTBUS7_RespAux] FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV8TTBUS_CodPosicion and [TTBUS7_CodUsuario] = @AV9USUARIO ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000A3,1,0,false,true )
             ,new CursorDef("P000A4", "SELECT [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @AV9USUARIO ORDER BY [TTBUS8_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000A4,1,0,false,true )
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
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
