/*
               File: PTBUS003_b_1
        Description: Confirma la baja del bien de uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:33.1
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
   public class ptbus003_b_1 : GXProcedure
   {
      public ptbus003_b_1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus003_b_1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_TTBUS_Id ,
                           ref String aP1_USUARIO )
      {
         this.AV8TTBUS_Id = aP0_TTBUS_Id;
         this.AV11USUARIO = aP1_USUARIO;
         initialize();
         executePrivate();
         aP0_TTBUS_Id=this.AV8TTBUS_Id;
         aP1_USUARIO=this.AV11USUARIO;
      }

      public String executeUdp( ref int aP0_TTBUS_Id )
      {
         this.AV8TTBUS_Id = aP0_TTBUS_Id;
         this.AV11USUARIO = aP1_USUARIO;
         initialize();
         executePrivate();
         aP0_TTBUS_Id=this.AV8TTBUS_Id;
         aP1_USUARIO=this.AV11USUARIO;
         return AV11USUARIO ;
      }

      public void executeSubmit( ref int aP0_TTBUS_Id ,
                                 ref String aP1_USUARIO )
      {
         ptbus003_b_1 objptbus003_b_1;
         objptbus003_b_1 = new ptbus003_b_1();
         objptbus003_b_1.AV8TTBUS_Id = aP0_TTBUS_Id;
         objptbus003_b_1.AV11USUARIO = aP1_USUARIO;
         objptbus003_b_1.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus003_b_1.executePrivateCatch ));
         aP0_TTBUS_Id=this.AV8TTBUS_Id;
         aP1_USUARIO=this.AV11USUARIO;
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
         /* Using cursor P00112 */
         pr_default.execute(0, new Object[] {AV8TTBUS_Id});
         pr_default.close(0);
         /* End optimized UPDATE. */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUS003_b_1");
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus003_b_1__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int AV8TTBUS_Id ;
      private String AV11USUARIO ;
      private IGxDataStore dsDefault ;
      private int aP0_TTBUS_Id ;
      private String aP1_USUARIO ;
      private IDataStoreProvider pr_default ;
   }

   public class ptbus003_b_1__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00112 ;
          prmP00112 = new Object[] {
          new Object[] {"@AV8TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00112", "UPDATE [TTBUS000] SET [TTBUS_Estado]=4  WHERE [TTBUS_Id] = @AV8TTBUS_Id", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00112)
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
