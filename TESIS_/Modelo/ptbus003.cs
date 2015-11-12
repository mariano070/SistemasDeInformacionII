/*
               File: PTBUS003
        Description: Cancelación de envío de un bien de uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:11.81
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
   public class ptbus003 : GXProcedure
   {
      public ptbus003( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus003( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_TTBUS2_IdMovimiento ,
                           ref int aP1_TTBUS_Id ,
                           ref String aP2_USUARIO )
      {
         this.AV8TTBUS2_IdMovimiento = aP0_TTBUS2_IdMovimiento;
         this.AV11TTBUS_Id = aP1_TTBUS_Id;
         this.AV16USUARIO = aP2_USUARIO;
         initialize();
         executePrivate();
         aP0_TTBUS2_IdMovimiento=this.AV8TTBUS2_IdMovimiento;
         aP1_TTBUS_Id=this.AV11TTBUS_Id;
         aP2_USUARIO=this.AV16USUARIO;
      }

      public String executeUdp( ref long aP0_TTBUS2_IdMovimiento ,
                                ref int aP1_TTBUS_Id )
      {
         this.AV8TTBUS2_IdMovimiento = aP0_TTBUS2_IdMovimiento;
         this.AV11TTBUS_Id = aP1_TTBUS_Id;
         this.AV16USUARIO = aP2_USUARIO;
         initialize();
         executePrivate();
         aP0_TTBUS2_IdMovimiento=this.AV8TTBUS2_IdMovimiento;
         aP1_TTBUS_Id=this.AV11TTBUS_Id;
         aP2_USUARIO=this.AV16USUARIO;
         return AV16USUARIO ;
      }

      public void executeSubmit( ref long aP0_TTBUS2_IdMovimiento ,
                                 ref int aP1_TTBUS_Id ,
                                 ref String aP2_USUARIO )
      {
         ptbus003 objptbus003;
         objptbus003 = new ptbus003();
         objptbus003.AV8TTBUS2_IdMovimiento = aP0_TTBUS2_IdMovimiento;
         objptbus003.AV11TTBUS_Id = aP1_TTBUS_Id;
         objptbus003.AV16USUARIO = aP2_USUARIO;
         objptbus003.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus003.executePrivateCatch ));
         aP0_TTBUS2_IdMovimiento=this.AV8TTBUS2_IdMovimiento;
         aP1_TTBUS_Id=this.AV11TTBUS_Id;
         aP2_USUARIO=this.AV16USUARIO;
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
         /* Using cursor P000G2 */
         pr_default.execute(0, new Object[] {AV8TTBUS2_IdMovimiento});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A52TTBUS2_IdMovimiento = P000G2_A52TTBUS2_IdMovimiento[0] ;
            A26TTBUS2_EstadoEnvio = P000G2_A26TTBUS2_EstadoEnvio[0] ;
            A48TTBUS2_CodPosDesde = P000G2_A48TTBUS2_CodPosDesde[0] ;
            A87TTBUS2_Observaciones = P000G2_A87TTBUS2_Observaciones[0] ;
            n87TTBUS2_Observaciones = P000G2_n87TTBUS2_Observaciones[0] ;
            A26TTBUS2_EstadoEnvio = 3 ;
            AV22TTBUS2_CodPosDesde = A48TTBUS2_CodPosDesde ;
            A87TTBUS2_Observaciones = StringUtil.Trim( A87TTBUS2_Observaciones) + " (MOVIMIENTO CANCELADO POR EL RESPONSABLE DE ENVÍO)." ;
            n87TTBUS2_Observaciones = false ;
            /* Using cursor P000G3 */
            pr_default.execute(1, new Object[] {A26TTBUS2_EstadoEnvio, n87TTBUS2_Observaciones, A87TTBUS2_Observaciones, A52TTBUS2_IdMovimiento});
            pr_default.close(1);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         /* Using cursor P000G4 */
         pr_default.execute(2, new Object[] {AV11TTBUS_Id});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A11TTBUS_Id = P000G4_A11TTBUS_Id[0] ;
            A37TTBUS_CodPosicion = P000G4_A37TTBUS_CodPosicion[0] ;
            A38TTBUS_DesPosicion = P000G4_A38TTBUS_DesPosicion[0] ;
            A23TTBUS_Estado = P000G4_A23TTBUS_Estado[0] ;
            new ptbus020_b(context ).execute(  AV22TTBUS2_CodPosDesde, out  AV23dTTBUS3_Des) ;
            A37TTBUS_CodPosicion = AV22TTBUS2_CodPosDesde ;
            A38TTBUS_DesPosicion = AV23dTTBUS3_Des ;
            A23TTBUS_Estado = 1 ;
            /* Using cursor P000G5 */
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
         context.CommitDataStores("PTBUS003");
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
         P000G2_A52TTBUS2_IdMovimiento = new long[1] ;
         P000G2_A26TTBUS2_EstadoEnvio = new short[1] ;
         P000G2_A48TTBUS2_CodPosDesde = new short[1] ;
         P000G2_A87TTBUS2_Observaciones = new String[] {""} ;
         P000G2_n87TTBUS2_Observaciones = new bool[] {false} ;
         A87TTBUS2_Observaciones = "" ;
         P000G4_A11TTBUS_Id = new int[1] ;
         P000G4_A37TTBUS_CodPosicion = new short[1] ;
         P000G4_A38TTBUS_DesPosicion = new String[] {""} ;
         P000G4_A23TTBUS_Estado = new short[1] ;
         A38TTBUS_DesPosicion = "" ;
         AV23dTTBUS3_Des = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus003__default(),
            new Object[][] {
                new Object[] {
               P000G2_A52TTBUS2_IdMovimiento, P000G2_A26TTBUS2_EstadoEnvio, P000G2_A48TTBUS2_CodPosDesde, P000G2_A87TTBUS2_Observaciones, P000G2_n87TTBUS2_Observaciones
               }
               , new Object[] {
               }
               , new Object[] {
               P000G4_A11TTBUS_Id, P000G4_A37TTBUS_CodPosicion, P000G4_A38TTBUS_DesPosicion, P000G4_A23TTBUS_Estado
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A26TTBUS2_EstadoEnvio ;
      private short A48TTBUS2_CodPosDesde ;
      private short AV22TTBUS2_CodPosDesde ;
      private short A37TTBUS_CodPosicion ;
      private short A23TTBUS_Estado ;
      private int AV11TTBUS_Id ;
      private int A11TTBUS_Id ;
      private long AV8TTBUS2_IdMovimiento ;
      private long A52TTBUS2_IdMovimiento ;
      private String AV16USUARIO ;
      private String scmdbuf ;
      private String A38TTBUS_DesPosicion ;
      private String AV23dTTBUS3_Des ;
      private bool n87TTBUS2_Observaciones ;
      private String A87TTBUS2_Observaciones ;
      private IGxDataStore dsDefault ;
      private long aP0_TTBUS2_IdMovimiento ;
      private int aP1_TTBUS_Id ;
      private String aP2_USUARIO ;
      private IDataStoreProvider pr_default ;
      private long[] P000G2_A52TTBUS2_IdMovimiento ;
      private short[] P000G2_A26TTBUS2_EstadoEnvio ;
      private short[] P000G2_A48TTBUS2_CodPosDesde ;
      private String[] P000G2_A87TTBUS2_Observaciones ;
      private bool[] P000G2_n87TTBUS2_Observaciones ;
      private int[] P000G4_A11TTBUS_Id ;
      private short[] P000G4_A37TTBUS_CodPosicion ;
      private String[] P000G4_A38TTBUS_DesPosicion ;
      private short[] P000G4_A23TTBUS_Estado ;
   }

   public class ptbus003__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000G2 ;
          prmP000G2 = new Object[] {
          new Object[] {"@AV8TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmP000G3 ;
          prmP000G3 = new Object[] {
          new Object[] {"@TTBUS2_EstadoEnvio",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS2_Observaciones",SqlDbType.VarChar,400,0} ,
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmP000G4 ;
          prmP000G4 = new Object[] {
          new Object[] {"@AV11TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP000G5 ;
          prmP000G5 = new Object[] {
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS_DesPosicion",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000G2", "SELECT [TTBUS2_IdMovimiento], [TTBUS2_EstadoEnvio], [TTBUS2_CodPosDesde], [TTBUS2_Observaciones] FROM [TTBUS002] WITH (UPDLOCK) WHERE [TTBUS2_IdMovimiento] = @AV8TTBUS2_IdMovimiento ORDER BY [TTBUS2_IdMovimiento] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000G2,1,0,true,true )
             ,new CursorDef("P000G3", "UPDATE [TTBUS002] SET [TTBUS2_EstadoEnvio]=@TTBUS2_EstadoEnvio, [TTBUS2_Observaciones]=@TTBUS2_Observaciones  WHERE [TTBUS2_IdMovimiento] = @TTBUS2_IdMovimiento", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000G3)
             ,new CursorDef("P000G4", "SELECT [TTBUS_Id], [TTBUS_CodPosicion], [TTBUS_DesPosicion], [TTBUS_Estado] FROM [TTBUS000] WITH (UPDLOCK) WHERE [TTBUS_Id] = @AV11TTBUS_Id ORDER BY [TTBUS_Id] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000G4,1,0,true,true )
             ,new CursorDef("P000G5", "UPDATE [TTBUS000] SET [TTBUS_CodPosicion]=@TTBUS_CodPosicion, [TTBUS_DesPosicion]=@TTBUS_DesPosicion, [TTBUS_Estado]=@TTBUS_Estado  WHERE [TTBUS_Id] = @TTBUS_Id", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000G5)
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
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
                stmt.SetParameter(1, (short)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
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
