/*
               File: PTBUS004
        Description: Recepción de envío de un bien de uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:9.93
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
   public class ptbus004 : GXProcedure
   {
      public ptbus004( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus004( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_TTBUS2_IdMovimiento ,
                           ref int aP1_TTBUS_Id )
      {
         this.AV12TTBUS2_IdMovimiento = aP0_TTBUS2_IdMovimiento;
         this.AV10TTBUS_Id = aP1_TTBUS_Id;
         initialize();
         executePrivate();
         aP0_TTBUS2_IdMovimiento=this.AV12TTBUS2_IdMovimiento;
         aP1_TTBUS_Id=this.AV10TTBUS_Id;
      }

      public int executeUdp( ref long aP0_TTBUS2_IdMovimiento )
      {
         this.AV12TTBUS2_IdMovimiento = aP0_TTBUS2_IdMovimiento;
         this.AV10TTBUS_Id = aP1_TTBUS_Id;
         initialize();
         executePrivate();
         aP0_TTBUS2_IdMovimiento=this.AV12TTBUS2_IdMovimiento;
         aP1_TTBUS_Id=this.AV10TTBUS_Id;
         return AV10TTBUS_Id ;
      }

      public void executeSubmit( ref long aP0_TTBUS2_IdMovimiento ,
                                 ref int aP1_TTBUS_Id )
      {
         ptbus004 objptbus004;
         objptbus004 = new ptbus004();
         objptbus004.AV12TTBUS2_IdMovimiento = aP0_TTBUS2_IdMovimiento;
         objptbus004.AV10TTBUS_Id = aP1_TTBUS_Id;
         objptbus004.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus004.executePrivateCatch ));
         aP0_TTBUS2_IdMovimiento=this.AV12TTBUS2_IdMovimiento;
         aP1_TTBUS_Id=this.AV10TTBUS_Id;
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
         /* Using cursor P00132 */
         pr_default.execute(0, new Object[] {AV12TTBUS2_IdMovimiento});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A52TTBUS2_IdMovimiento = P00132_A52TTBUS2_IdMovimiento[0] ;
            A46TTBUS2_FechaRecepcion = P00132_A46TTBUS2_FechaRecepcion[0] ;
            n46TTBUS2_FechaRecepcion = P00132_n46TTBUS2_FechaRecepcion[0] ;
            A26TTBUS2_EstadoEnvio = P00132_A26TTBUS2_EstadoEnvio[0] ;
            A49TTBUS2_CodPosHacia = P00132_A49TTBUS2_CodPosHacia[0] ;
            A46TTBUS2_FechaRecepcion = DateTimeUtil.Now( ) ;
            n46TTBUS2_FechaRecepcion = false ;
            A26TTBUS2_EstadoEnvio = 2 ;
            AV14TTBUS2_CodPosHacia = A49TTBUS2_CodPosHacia ;
            /* Using cursor P00133 */
            pr_default.execute(1, new Object[] {n46TTBUS2_FechaRecepcion, A46TTBUS2_FechaRecepcion, A26TTBUS2_EstadoEnvio, A52TTBUS2_IdMovimiento});
            pr_default.close(1);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         /* Using cursor P00134 */
         pr_default.execute(2, new Object[] {AV10TTBUS_Id});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A11TTBUS_Id = P00134_A11TTBUS_Id[0] ;
            A37TTBUS_CodPosicion = P00134_A37TTBUS_CodPosicion[0] ;
            A38TTBUS_DesPosicion = P00134_A38TTBUS_DesPosicion[0] ;
            A23TTBUS_Estado = P00134_A23TTBUS_Estado[0] ;
            new ptbus020_b(context ).execute(  AV14TTBUS2_CodPosHacia, out  AV15hTTBUS3_Des) ;
            A37TTBUS_CodPosicion = AV14TTBUS2_CodPosHacia ;
            A38TTBUS_DesPosicion = AV15hTTBUS3_Des ;
            A23TTBUS_Estado = 1 ;
            /* Using cursor P00135 */
            pr_default.execute(3, new Object[] {A37TTBUS_CodPosicion, A38TTBUS_DesPosicion, A23TTBUS_Estado, A11TTBUS_Id});
            pr_default.close(3);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(2);
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUS004");
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
         P00132_A52TTBUS2_IdMovimiento = new long[1] ;
         P00132_A46TTBUS2_FechaRecepcion = new DateTime[] {DateTime.MinValue} ;
         P00132_n46TTBUS2_FechaRecepcion = new bool[] {false} ;
         P00132_A26TTBUS2_EstadoEnvio = new short[1] ;
         P00132_A49TTBUS2_CodPosHacia = new short[1] ;
         A46TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
         P00134_A11TTBUS_Id = new int[1] ;
         P00134_A37TTBUS_CodPosicion = new short[1] ;
         P00134_A38TTBUS_DesPosicion = new String[] {""} ;
         P00134_A23TTBUS_Estado = new short[1] ;
         A38TTBUS_DesPosicion = "" ;
         AV15hTTBUS3_Des = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus004__default(),
            new Object[][] {
                new Object[] {
               P00132_A52TTBUS2_IdMovimiento, P00132_A46TTBUS2_FechaRecepcion, P00132_n46TTBUS2_FechaRecepcion, P00132_A26TTBUS2_EstadoEnvio, P00132_A49TTBUS2_CodPosHacia
               }
               , new Object[] {
               }
               , new Object[] {
               P00134_A11TTBUS_Id, P00134_A37TTBUS_CodPosicion, P00134_A38TTBUS_DesPosicion, P00134_A23TTBUS_Estado
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A26TTBUS2_EstadoEnvio ;
      private short A49TTBUS2_CodPosHacia ;
      private short AV14TTBUS2_CodPosHacia ;
      private short A37TTBUS_CodPosicion ;
      private short A23TTBUS_Estado ;
      private int AV10TTBUS_Id ;
      private int A11TTBUS_Id ;
      private long AV12TTBUS2_IdMovimiento ;
      private long A52TTBUS2_IdMovimiento ;
      private String scmdbuf ;
      private String A38TTBUS_DesPosicion ;
      private String AV15hTTBUS3_Des ;
      private DateTime A46TTBUS2_FechaRecepcion ;
      private bool n46TTBUS2_FechaRecepcion ;
      private IGxDataStore dsDefault ;
      private long aP0_TTBUS2_IdMovimiento ;
      private int aP1_TTBUS_Id ;
      private IDataStoreProvider pr_default ;
      private long[] P00132_A52TTBUS2_IdMovimiento ;
      private DateTime[] P00132_A46TTBUS2_FechaRecepcion ;
      private bool[] P00132_n46TTBUS2_FechaRecepcion ;
      private short[] P00132_A26TTBUS2_EstadoEnvio ;
      private short[] P00132_A49TTBUS2_CodPosHacia ;
      private int[] P00134_A11TTBUS_Id ;
      private short[] P00134_A37TTBUS_CodPosicion ;
      private String[] P00134_A38TTBUS_DesPosicion ;
      private short[] P00134_A23TTBUS_Estado ;
   }

   public class ptbus004__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new UpdateCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00132 ;
          prmP00132 = new Object[] {
          new Object[] {"@AV12TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmP00133 ;
          prmP00133 = new Object[] {
          new Object[] {"@TTBUS2_FechaRecepcion",SqlDbType.DateTime,8,5} ,
          new Object[] {"@TTBUS2_EstadoEnvio",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmP00134 ;
          prmP00134 = new Object[] {
          new Object[] {"@AV10TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP00135 ;
          prmP00135 = new Object[] {
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS_DesPosicion",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00132", "SELECT [TTBUS2_IdMovimiento], [TTBUS2_FechaRecepcion], [TTBUS2_EstadoEnvio], [TTBUS2_CodPosHacia] FROM [TTBUS002] WITH (UPDLOCK) WHERE [TTBUS2_IdMovimiento] = @AV12TTBUS2_IdMovimiento ORDER BY [TTBUS2_IdMovimiento] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00132,1,0,true,true )
             ,new CursorDef("P00133", "UPDATE [TTBUS002] SET [TTBUS2_FechaRecepcion]=@TTBUS2_FechaRecepcion, [TTBUS2_EstadoEnvio]=@TTBUS2_EstadoEnvio  WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00133)
             ,new CursorDef("P00134", "SELECT [TTBUS_Id], [TTBUS_CodPosicion], [TTBUS_DesPosicion], [TTBUS_Estado] FROM [TTBUS000] WITH (UPDLOCK) WHERE [TTBUS_Id] = @AV10TTBUS_Id ORDER BY [TTBUS_Id] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00134,1,0,true,true )
             ,new CursorDef("P00135", "UPDATE [TTBUS000] SET [TTBUS_CodPosicion]=@TTBUS_CodPosicion, [TTBUS_DesPosicion]=@TTBUS_DesPosicion, [TTBUS_Estado]=@TTBUS_Estado  WHERE [TTBUS_Id] = @TTBUS_Id", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00135)
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(1, (DateTime)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (long)parms[3]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
       }
    }

 }

}
