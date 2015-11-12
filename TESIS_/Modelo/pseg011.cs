/*
               File: PSEG011
        Description: CAMBIA CONTRASEÑA
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:45.25
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
   public class pseg011 : GXProcedure
   {
      public pseg011( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pseg011( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USUCOD ,
                           ref String aP1_USUCLA )
      {
         this.AV8USUCOD = aP0_USUCOD;
         this.AV9USUCLA = aP1_USUCLA;
         initialize();
         executePrivate();
         aP0_USUCOD=this.AV8USUCOD;
         aP1_USUCLA=this.AV9USUCLA;
      }

      public String executeUdp( ref String aP0_USUCOD )
      {
         this.AV8USUCOD = aP0_USUCOD;
         this.AV9USUCLA = aP1_USUCLA;
         initialize();
         executePrivate();
         aP0_USUCOD=this.AV8USUCOD;
         aP1_USUCLA=this.AV9USUCLA;
         return AV9USUCLA ;
      }

      public void executeSubmit( ref String aP0_USUCOD ,
                                 ref String aP1_USUCLA )
      {
         pseg011 objpseg011;
         objpseg011 = new pseg011();
         objpseg011.AV8USUCOD = aP0_USUCOD;
         objpseg011.AV9USUCLA = aP1_USUCLA;
         objpseg011.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpseg011.executePrivateCatch ));
         aP0_USUCOD=this.AV8USUCOD;
         aP1_USUCLA=this.AV9USUCLA;
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
         /* Using cursor P000R2 */
         pr_default.execute(0, new Object[] {AV9USUCLA, AV8USUCOD});
         pr_default.close(0);
         /* End optimized UPDATE. */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PSEG011");
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
         A155USU_CLA = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pseg011__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private String AV8USUCOD ;
      private String AV9USUCLA ;
      private String A155USU_CLA ;
      private IGxDataStore dsDefault ;
      private String aP0_USUCOD ;
      private String aP1_USUCLA ;
      private IDataStoreProvider pr_default ;
   }

   public class pseg011__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000R2 ;
          prmP000R2 = new Object[] {
          new Object[] {"@USU_CLA",SqlDbType.Char,20,0} ,
          new Object[] {"@AV8USUCOD",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000R2", "UPDATE [SEG002] SET [USU_CLA]=@USU_CLA  WHERE [USU_COD] = @AV8USUCOD", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000R2)
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
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
