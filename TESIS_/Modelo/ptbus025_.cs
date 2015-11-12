/*
               File: PTBUS025_
        Description: Restricción a Posiciones sin Responsabilidad
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:2.53
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
   public class ptbus025_ : GXProcedure
   {
      public ptbus025_( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus025_( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_USUARIO ,
                           short aP1_TTBUS_CodPosicion ,
                           out short aP2_band_1 )
      {
         this.AV10USUARIO = aP0_USUARIO;
         this.AV11TTBUS_CodPosicion = aP1_TTBUS_CodPosicion;
         this.AV9band_1 = 0 ;
         initialize();
         executePrivate();
         aP2_band_1=this.AV9band_1;
      }

      public short executeUdp( String aP0_USUARIO ,
                               short aP1_TTBUS_CodPosicion )
      {
         this.AV10USUARIO = aP0_USUARIO;
         this.AV11TTBUS_CodPosicion = aP1_TTBUS_CodPosicion;
         this.AV9band_1 = 0 ;
         initialize();
         executePrivate();
         aP2_band_1=this.AV9band_1;
         return AV9band_1 ;
      }

      public void executeSubmit( String aP0_USUARIO ,
                                 short aP1_TTBUS_CodPosicion ,
                                 out short aP2_band_1 )
      {
         ptbus025_ objptbus025_;
         objptbus025_ = new ptbus025_();
         objptbus025_.AV10USUARIO = aP0_USUARIO;
         objptbus025_.AV11TTBUS_CodPosicion = aP1_TTBUS_CodPosicion;
         objptbus025_.AV9band_1 = 0 ;
         objptbus025_.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus025_.executePrivateCatch ));
         aP2_band_1=this.AV9band_1;
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
         AV9band_1 = 0 ;
         if ( StringUtil.StrCmp(AV10USUARIO, "SUPERVISOR") == 0 )
         {
            AV9band_1 = 1 ;
         }
         if ( AV9band_1 == 0 )
         {
            /* Using cursor P000L2 */
            pr_default.execute(0, new Object[] {AV10USUARIO});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A40TTBUS8_CodUsuario = P000L2_A40TTBUS8_CodUsuario[0] ;
               AV9band_1 = 1 ;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
         }
         if ( AV9band_1 == 0 )
         {
            /* Using cursor P000L3 */
            pr_default.execute(1, new Object[] {AV11TTBUS_CodPosicion, AV10USUARIO});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A33TTBUS7_Pos = P000L3_A33TTBUS7_Pos[0] ;
               A35TTBUS7_CodResp = P000L3_A35TTBUS7_CodResp[0] ;
               AV9band_1 = 1 ;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
         }
         if ( AV9band_1 == 0 )
         {
            /* Using cursor P000L4 */
            pr_default.execute(2, new Object[] {AV11TTBUS_CodPosicion, AV10USUARIO});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A33TTBUS7_Pos = P000L4_A33TTBUS7_Pos[0] ;
               A35TTBUS7_CodResp = P000L4_A35TTBUS7_CodResp[0] ;
               AV9band_1 = 1 ;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
            /* Using cursor P000L5 */
            pr_default.execute(3, new Object[] {AV11TTBUS_CodPosicion, AV10USUARIO});
            while ( (pr_default.getStatus(3) != 101) )
            {
               A39TTBUS7_CodUsuario = P000L5_A39TTBUS7_CodUsuario[0] ;
               A33TTBUS7_Pos = P000L5_A33TTBUS7_Pos[0] ;
               A51TTBUS7_RespAux = P000L5_A51TTBUS7_RespAux[0] ;
               if ( A51TTBUS7_RespAux == 1 )
               {
                  AV9band_1 = 1 ;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(3);
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
         P000L2_A40TTBUS8_CodUsuario = new String[] {""} ;
         A40TTBUS8_CodUsuario = "" ;
         P000L3_A33TTBUS7_Pos = new short[1] ;
         P000L3_A35TTBUS7_CodResp = new String[] {""} ;
         A35TTBUS7_CodResp = "" ;
         P000L4_A33TTBUS7_Pos = new short[1] ;
         P000L4_A35TTBUS7_CodResp = new String[] {""} ;
         P000L5_A39TTBUS7_CodUsuario = new String[] {""} ;
         P000L5_A33TTBUS7_Pos = new short[1] ;
         P000L5_A51TTBUS7_RespAux = new short[1] ;
         A39TTBUS7_CodUsuario = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus025___default(),
            new Object[][] {
                new Object[] {
               P000L2_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               P000L3_A33TTBUS7_Pos, P000L3_A35TTBUS7_CodResp
               }
               , new Object[] {
               P000L4_A33TTBUS7_Pos, P000L4_A35TTBUS7_CodResp
               }
               , new Object[] {
               P000L5_A39TTBUS7_CodUsuario, P000L5_A33TTBUS7_Pos, P000L5_A51TTBUS7_RespAux
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV11TTBUS_CodPosicion ;
      private short AV9band_1 ;
      private short A33TTBUS7_Pos ;
      private short A51TTBUS7_RespAux ;
      private String AV10USUARIO ;
      private String scmdbuf ;
      private String A40TTBUS8_CodUsuario ;
      private String A35TTBUS7_CodResp ;
      private String A39TTBUS7_CodUsuario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000L2_A40TTBUS8_CodUsuario ;
      private short[] P000L3_A33TTBUS7_Pos ;
      private String[] P000L3_A35TTBUS7_CodResp ;
      private short[] P000L4_A33TTBUS7_Pos ;
      private String[] P000L4_A35TTBUS7_CodResp ;
      private String[] P000L5_A39TTBUS7_CodUsuario ;
      private short[] P000L5_A33TTBUS7_Pos ;
      private short[] P000L5_A51TTBUS7_RespAux ;
      private short aP2_band_1 ;
   }

   public class ptbus025___default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000L2 ;
          prmP000L2 = new Object[] {
          new Object[] {"@AV10USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmP000L3 ;
          prmP000L3 = new Object[] {
          new Object[] {"@AV11TTBUS_CodPosicion",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV10USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmP000L4 ;
          prmP000L4 = new Object[] {
          new Object[] {"@AV11TTBUS_CodPosicion",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV10USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmP000L5 ;
          prmP000L5 = new Object[] {
          new Object[] {"@AV11TTBUS_CodPosicion",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV10USUARIO",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000L2", "SELECT TOP 1 [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @AV10USUARIO ORDER BY [TTBUS8_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000L2,1,0,false,true )
             ,new CursorDef("P000L3", "SELECT TOP 1 [TTBUS7_Pos], [TTBUS7_CodResp] FROM [TTBUS007] WITH (NOLOCK) WHERE ([TTBUS7_Pos] = @AV11TTBUS_CodPosicion) AND ([TTBUS7_CodResp] = @AV10USUARIO) ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000L3,1,0,false,true )
             ,new CursorDef("P000L4", "SELECT TOP 1 [TTBUS7_Pos], [TTBUS7_CodResp] FROM [TTBUS007] WITH (NOLOCK) WHERE ([TTBUS7_Pos] = @AV11TTBUS_CodPosicion) AND ([TTBUS7_CodResp] = @AV10USUARIO) ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000L4,1,0,false,true )
             ,new CursorDef("P000L5", "SELECT [TTBUS7_CodUsuario], [TTBUS7_Pos], [TTBUS7_RespAux] FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV11TTBUS_CodPosicion and [TTBUS7_CodUsuario] = @AV10USUARIO ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000L5,1,0,false,true )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
