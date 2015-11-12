/*
               File: PTBUS075
        Description: Cambio de posiciones
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/29/2014 16:46:19.12
       Program type: Main program
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
   public class aptbus075 : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
   {
      public override void webExecute( )
      {
         context.SetTheme("Modern");
         initialize();
         if ( nGotPars == 0 )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
         }
         executePrivate();
         cleanup();
      }

      public aptbus075( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aptbus075( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         aptbus075 objaptbus075;
         objaptbus075 = new aptbus075();
         objaptbus075.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaptbus075.executePrivateCatch ));
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
         /* Using cursor P001W2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A244TTBUS75_PosAnterior = P001W2_A244TTBUS75_PosAnterior[0] ;
            A245TTBUS75_PosNueva = P001W2_A245TTBUS75_PosNueva[0] ;
            A243TTBUS75_Orden = P001W2_A243TTBUS75_Orden[0] ;
            AV8pos_anterior = A244TTBUS75_PosAnterior ;
            AV9pos_nueva = A245TTBUS75_PosNueva ;
            /* Optimized UPDATE. */
            /* Using cursor P001W3 */
            pr_default.execute(1, new Object[] {AV9pos_nueva, AV8pos_anterior});
            pr_default.close(1);
            /* End optimized UPDATE. */
            /* Optimized UPDATE. */
            /* Using cursor P001W4 */
            pr_default.execute(2, new Object[] {AV9pos_nueva, AV8pos_anterior});
            pr_default.close(2);
            /* End optimized UPDATE. */
            /* Optimized UPDATE. */
            /* Using cursor P001W5 */
            pr_default.execute(3, new Object[] {AV9pos_nueva, AV8pos_anterior});
            pr_default.close(3);
            /* End optimized UPDATE. */
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
         {
            context.Redirect( context.wjLoc );
            context.wjLoc = "" ;
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUS075");
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
         gxfirstwebparm = "" ;
         scmdbuf = "" ;
         P001W2_A244TTBUS75_PosAnterior = new short[1] ;
         P001W2_A245TTBUS75_PosNueva = new short[1] ;
         P001W2_A243TTBUS75_Orden = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aptbus075__default(),
            new Object[][] {
                new Object[] {
               P001W2_A244TTBUS75_PosAnterior, P001W2_A245TTBUS75_PosNueva, P001W2_A243TTBUS75_Orden
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short A244TTBUS75_PosAnterior ;
      private short A245TTBUS75_PosNueva ;
      private short A243TTBUS75_Orden ;
      private short AV8pos_anterior ;
      private short AV9pos_nueva ;
      private short A48TTBUS2_CodPosDesde ;
      private short A49TTBUS2_CodPosHacia ;
      private short A37TTBUS_CodPosicion ;
      private String gxfirstwebparm ;
      private String scmdbuf ;
      private bool entryPointCalled ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001W2_A244TTBUS75_PosAnterior ;
      private short[] P001W2_A245TTBUS75_PosNueva ;
      private short[] P001W2_A243TTBUS75_Orden ;
   }

   public class aptbus075__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new UpdateCursor(def[2])
         ,new UpdateCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001W2 ;
          prmP001W2 = new Object[] {
          } ;
          Object[] prmP001W3 ;
          prmP001W3 = new Object[] {
          new Object[] {"@TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV8pos_anterior",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP001W4 ;
          prmP001W4 = new Object[] {
          new Object[] {"@TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV8pos_anterior",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP001W5 ;
          prmP001W5 = new Object[] {
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV8pos_anterior",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001W2", "SELECT [TTBUS75_PosAnterior], [TTBUS75_PosNueva], [TTBUS75_Orden] FROM [TTBUS075] WITH (NOLOCK) ORDER BY [TTBUS75_Orden] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001W2,100,0,true,false )
             ,new CursorDef("P001W3", "UPDATE [TTBUS002] SET [TTBUS2_CodPosDesde]=@TTBUS2_CodPosDesde  WHERE [TTBUS2_CodPosDesde] = @AV8pos_anterior", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001W3)
             ,new CursorDef("P001W4", "UPDATE [TTBUS002] SET [TTBUS2_CodPosHacia]=@TTBUS2_CodPosHacia  WHERE [TTBUS2_CodPosHacia] = @AV8pos_anterior", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001W4)
             ,new CursorDef("P001W5", "UPDATE [TTBUS000] SET [TTBUS_CodPosicion]=@TTBUS_CodPosicion  WHERE [TTBUS_CodPosicion] = @AV8pos_anterior", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001W5)
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
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
       }
    }

 }

}
