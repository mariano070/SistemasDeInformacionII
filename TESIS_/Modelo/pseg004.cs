/*
               File: PSEG004
        Description: BORRA USUARIO
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/5/2014 11:31:1.62
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
   public class pseg004 : GXProcedure
   {
      public pseg004( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pseg004( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USUCOD )
      {
         this.AV8USUCOD = aP0_USUCOD;
         initialize();
         executePrivate();
         aP0_USUCOD=this.AV8USUCOD;
      }

      public String executeUdp( )
      {
         this.AV8USUCOD = aP0_USUCOD;
         initialize();
         executePrivate();
         aP0_USUCOD=this.AV8USUCOD;
         return AV8USUCOD ;
      }

      public void executeSubmit( ref String aP0_USUCOD )
      {
         pseg004 objpseg004;
         objpseg004 = new pseg004();
         objpseg004.AV8USUCOD = aP0_USUCOD;
         objpseg004.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpseg004.executePrivateCatch ));
         aP0_USUCOD=this.AV8USUCOD;
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
         /* Optimized DELETE. */
         /* Using cursor P002B2 */
         pr_default.execute(0, new Object[] {AV8USUCOD});
         pr_default.close(0);
         /* End optimized DELETE. */
         /* Optimized DELETE. */
         /* Using cursor P002B3 */
         pr_default.execute(1, new Object[] {AV8USUCOD});
         pr_default.close(1);
         /* End optimized DELETE. */
         /* Optimized DELETE. */
         /* Using cursor P002B4 */
         pr_default.execute(2, new Object[] {AV8USUCOD});
         pr_default.close(2);
         /* End optimized DELETE. */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PSEG004");
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pseg004__default(),
            new Object[][] {
                new Object[] {
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

      private String AV8USUCOD ;
      private IGxDataStore dsDefault ;
      private String aP0_USUCOD ;
      private IDataStoreProvider pr_default ;
   }

   public class pseg004__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new UpdateCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002B2 ;
          prmP002B2 = new Object[] {
          new Object[] {"@AV8USUCOD",SqlDbType.Char,16,0}
          } ;
          Object[] prmP002B3 ;
          prmP002B3 = new Object[] {
          new Object[] {"@AV8USUCOD",SqlDbType.Char,16,0}
          } ;
          Object[] prmP002B4 ;
          prmP002B4 = new Object[] {
          new Object[] {"@AV8USUCOD",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002B2", "DELETE FROM [SEG002]  WHERE [USU_COD] = @AV8USUCOD", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B2)
             ,new CursorDef("P002B3", "DELETE FROM [SEG004]  WHERE [USU_COD] = @AV8USUCOD", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B3)
             ,new CursorDef("P002B4", "DELETE FROM [SEG004]  WHERE [USU_COD] = @AV8USUCOD", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B4)
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
