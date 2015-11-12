/*
               File: PTBUS003_b_2
        Description: Rechaza baja de bien de uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:45.39
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
   public class ptbus003_b_2 : GXProcedure
   {
      public ptbus003_b_2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus003_b_2( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_TTBUS_Id )
      {
         this.AV8TTBUS_Id = aP0_TTBUS_Id;
         initialize();
         executePrivate();
         aP0_TTBUS_Id=this.AV8TTBUS_Id;
      }

      public int executeUdp( )
      {
         this.AV8TTBUS_Id = aP0_TTBUS_Id;
         initialize();
         executePrivate();
         aP0_TTBUS_Id=this.AV8TTBUS_Id;
         return AV8TTBUS_Id ;
      }

      public void executeSubmit( ref int aP0_TTBUS_Id )
      {
         ptbus003_b_2 objptbus003_b_2;
         objptbus003_b_2 = new ptbus003_b_2();
         objptbus003_b_2.AV8TTBUS_Id = aP0_TTBUS_Id;
         objptbus003_b_2.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus003_b_2.executePrivateCatch ));
         aP0_TTBUS_Id=this.AV8TTBUS_Id;
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
         /* Optimized UPDATE. */
         /* Using cursor P00122 */
         pr_default.execute(0, new Object[] {AV8TTBUS_Id});
         pr_default.close(0);
         /* End optimized UPDATE. */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUS003_b_2");
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus003_b_2__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int AV8TTBUS_Id ;
      private IGxDataStore dsDefault ;
      private int aP0_TTBUS_Id ;
      private IDataStoreProvider pr_default ;
   }

   public class ptbus003_b_2__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00122 ;
          prmP00122 = new Object[] {
          new Object[] {"@AV8TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00122", "UPDATE [TTBUS000] SET [TTBUS_Estado]=1, [TTBUS_FechaBaja]=convert( DATETIME, '17530101', 112 ), [TTBUS_MotivoBaja]='', [TTBUS_UsuarioBaja]='', [TTBUS_MaquinaBaja]=''  WHERE [TTBUS_Id] = @AV8TTBUS_Id", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00122)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
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
