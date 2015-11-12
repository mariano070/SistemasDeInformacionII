/*
               File: PTBUS033
        Description: Valida que un bien de uso esté dado de baja en trazabilidad
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:47:12.42
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
   public class ptbus033 : GXProcedure
   {
      public ptbus033( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus033( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( int aP0_TTBUS_Id ,
                           out short aP1_error )
      {
         this.AV9TTBUS_Id = aP0_TTBUS_Id;
         this.AV10error = 0 ;
         initialize();
         executePrivate();
         aP1_error=this.AV10error;
      }

      public short executeUdp( int aP0_TTBUS_Id )
      {
         this.AV9TTBUS_Id = aP0_TTBUS_Id;
         this.AV10error = 0 ;
         initialize();
         executePrivate();
         aP1_error=this.AV10error;
         return AV10error ;
      }

      public void executeSubmit( int aP0_TTBUS_Id ,
                                 out short aP1_error )
      {
         ptbus033 objptbus033;
         objptbus033 = new ptbus033();
         objptbus033.AV9TTBUS_Id = aP0_TTBUS_Id;
         objptbus033.AV10error = 0 ;
         objptbus033.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus033.executePrivateCatch ));
         aP1_error=this.AV10error;
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
         AV10error = 0 ;
         /* Using cursor P001V2 */
         pr_default.execute(0, new Object[] {AV9TTBUS_Id});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11TTBUS_Id = P001V2_A11TTBUS_Id[0] ;
            A16TTBUS_FechaBaja = P001V2_A16TTBUS_FechaBaja[0] ;
            n16TTBUS_FechaBaja = P001V2_n16TTBUS_FechaBaja[0] ;
            if ( (DateTime.MinValue==A16TTBUS_FechaBaja) )
            {
               AV10error = 1 ;
            }
            /* Exiting from a For First loop. */
            if (true) break;
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
         P001V2_A11TTBUS_Id = new int[1] ;
         P001V2_A16TTBUS_FechaBaja = new DateTime[] {DateTime.MinValue} ;
         P001V2_n16TTBUS_FechaBaja = new bool[] {false} ;
         A16TTBUS_FechaBaja = DateTime.MinValue ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus033__default(),
            new Object[][] {
                new Object[] {
               P001V2_A11TTBUS_Id, P001V2_A16TTBUS_FechaBaja, P001V2_n16TTBUS_FechaBaja
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV10error ;
      private int AV9TTBUS_Id ;
      private int A11TTBUS_Id ;
      private String scmdbuf ;
      private DateTime A16TTBUS_FechaBaja ;
      private bool n16TTBUS_FechaBaja ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] P001V2_A11TTBUS_Id ;
      private DateTime[] P001V2_A16TTBUS_FechaBaja ;
      private bool[] P001V2_n16TTBUS_FechaBaja ;
      private short aP1_error ;
   }

   public class ptbus033__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001V2 ;
          prmP001V2 = new Object[] {
          new Object[] {"@AV9TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001V2", "SELECT [TTBUS_Id], [TTBUS_FechaBaja] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @AV9TTBUS_Id ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001V2,1,0,false,true )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
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
       }
    }

 }

}
