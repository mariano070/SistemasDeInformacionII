/*
               File: PTBUS001
        Description: Controla que el bien en movimiento está asociado al usuario
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:28:58.5
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
   public class ptbus001 : GXProcedure
   {
      public ptbus001( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus001( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( int aP0_TTBUS_Id ,
                           String aP1_USUARIO ,
                           out short aP2_band )
      {
         this.AV8TTBUS_Id = aP0_TTBUS_Id;
         this.AV9USUARIO = aP1_USUARIO;
         this.AV10band = 0 ;
         initialize();
         executePrivate();
         aP2_band=this.AV10band;
      }

      public short executeUdp( int aP0_TTBUS_Id ,
                               String aP1_USUARIO )
      {
         this.AV8TTBUS_Id = aP0_TTBUS_Id;
         this.AV9USUARIO = aP1_USUARIO;
         this.AV10band = 0 ;
         initialize();
         executePrivate();
         aP2_band=this.AV10band;
         return AV10band ;
      }

      public void executeSubmit( int aP0_TTBUS_Id ,
                                 String aP1_USUARIO ,
                                 out short aP2_band )
      {
         ptbus001 objptbus001;
         objptbus001 = new ptbus001();
         objptbus001.AV8TTBUS_Id = aP0_TTBUS_Id;
         objptbus001.AV9USUARIO = aP1_USUARIO;
         objptbus001.AV10band = 0 ;
         objptbus001.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus001.executePrivateCatch ));
         aP2_band=this.AV10band;
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
         AV10band = 0 ;
         /* Using cursor P000M2 */
         pr_default.execute(0, new Object[] {AV8TTBUS_Id});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A26TTBUS2_EstadoEnvio = P000M2_A26TTBUS2_EstadoEnvio[0] ;
            A22TTBUS2_IdBien = P000M2_A22TTBUS2_IdBien[0] ;
            A24TTBUS2_RespDesde = P000M2_A24TTBUS2_RespDesde[0] ;
            A25TTBUS2_RespHacia = P000M2_A25TTBUS2_RespHacia[0] ;
            A52TTBUS2_IdMovimiento = P000M2_A52TTBUS2_IdMovimiento[0] ;
            AV11TTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
            if ( StringUtil.StrCmp(A24TTBUS2_RespDesde, AV9USUARIO) == 0 )
            {
               AV10band = 1 ;
            }
            else if ( StringUtil.StrCmp(A25TTBUS2_RespHacia, AV9USUARIO) == 0 )
            {
               AV10band = 1 ;
            }
            else
            {
               /* Using cursor P000M3 */
               pr_default.execute(1, new Object[] {AV11TTBUS2_IdMovimiento, AV9USUARIO});
               while ( (pr_default.getStatus(1) != 101) )
               {
                  A53TTBUS2_IdUsuario = P000M3_A53TTBUS2_IdUsuario[0] ;
                  A52TTBUS2_IdMovimiento = P000M3_A52TTBUS2_IdMovimiento[0] ;
                  AV10band = 1 ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(1);
            }
            pr_default.readNext(0);
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
         P000M2_A26TTBUS2_EstadoEnvio = new short[1] ;
         P000M2_A22TTBUS2_IdBien = new int[1] ;
         P000M2_A24TTBUS2_RespDesde = new String[] {""} ;
         P000M2_A25TTBUS2_RespHacia = new String[] {""} ;
         P000M2_A52TTBUS2_IdMovimiento = new long[1] ;
         A24TTBUS2_RespDesde = "" ;
         A25TTBUS2_RespHacia = "" ;
         P000M3_A53TTBUS2_IdUsuario = new String[] {""} ;
         P000M3_A52TTBUS2_IdMovimiento = new long[1] ;
         A53TTBUS2_IdUsuario = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus001__default(),
            new Object[][] {
                new Object[] {
               P000M2_A26TTBUS2_EstadoEnvio, P000M2_A22TTBUS2_IdBien, P000M2_A24TTBUS2_RespDesde, P000M2_A25TTBUS2_RespHacia, P000M2_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P000M3_A53TTBUS2_IdUsuario, P000M3_A52TTBUS2_IdMovimiento
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV10band ;
      private short A26TTBUS2_EstadoEnvio ;
      private int AV8TTBUS_Id ;
      private int A22TTBUS2_IdBien ;
      private long A52TTBUS2_IdMovimiento ;
      private long AV11TTBUS2_IdMovimiento ;
      private String AV9USUARIO ;
      private String scmdbuf ;
      private String A24TTBUS2_RespDesde ;
      private String A25TTBUS2_RespHacia ;
      private String A53TTBUS2_IdUsuario ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000M2_A26TTBUS2_EstadoEnvio ;
      private int[] P000M2_A22TTBUS2_IdBien ;
      private String[] P000M2_A24TTBUS2_RespDesde ;
      private String[] P000M2_A25TTBUS2_RespHacia ;
      private long[] P000M2_A52TTBUS2_IdMovimiento ;
      private String[] P000M3_A53TTBUS2_IdUsuario ;
      private long[] P000M3_A52TTBUS2_IdMovimiento ;
      private short aP2_band ;
   }

   public class ptbus001__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000M2 ;
          prmP000M2 = new Object[] {
          new Object[] {"@AV8TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP000M3 ;
          prmP000M3 = new Object[] {
          new Object[] {"@AV11TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0} ,
          new Object[] {"@AV9USUARIO",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000M2", "SELECT [TTBUS2_EstadoEnvio], [TTBUS2_IdBien], [TTBUS2_RespDesde], [TTBUS2_RespHacia], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdBien] = @AV8TTBUS_Id) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000M2,100,0,true,false )
             ,new CursorDef("P000M3", "SELECT [TTBUS2_IdUsuario], [TTBUS2_IdMovimiento] FROM [TTBUS002_Det] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @AV11TTBUS2_IdMovimiento and [TTBUS2_IdUsuario] = @AV9USUARIO ORDER BY [TTBUS2_IdMovimiento], [TTBUS2_IdUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000M3,1,0,false,true )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 15) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
