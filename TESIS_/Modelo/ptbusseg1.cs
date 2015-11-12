/*
               File: PTBUSSEG1
        Description: Alta en SEG002
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:45.66
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
   public class ptbusseg1 : GXProcedure
   {
      public ptbusseg1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbusseg1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USU_COD ,
                           ref String aP1_USU_DES ,
                           ref String aP2_USU_CLA ,
                           ref String aP3_USU_INT ,
                           ref String aP4_USU_MAIW ,
                           ref String aP5_Modo )
      {
         this.AV8USU_COD = aP0_USU_COD;
         this.AV9USU_DES = aP1_USU_DES;
         this.AV10USU_CLA = aP2_USU_CLA;
         this.AV12USU_INT = aP3_USU_INT;
         this.AV13USU_MAIW = aP4_USU_MAIW;
         this.AV11Modo = aP5_Modo;
         initialize();
         executePrivate();
         aP0_USU_COD=this.AV8USU_COD;
         aP1_USU_DES=this.AV9USU_DES;
         aP2_USU_CLA=this.AV10USU_CLA;
         aP3_USU_INT=this.AV12USU_INT;
         aP4_USU_MAIW=this.AV13USU_MAIW;
         aP5_Modo=this.AV11Modo;
      }

      public String executeUdp( ref String aP0_USU_COD ,
                                ref String aP1_USU_DES ,
                                ref String aP2_USU_CLA ,
                                ref String aP3_USU_INT ,
                                ref String aP4_USU_MAIW )
      {
         this.AV8USU_COD = aP0_USU_COD;
         this.AV9USU_DES = aP1_USU_DES;
         this.AV10USU_CLA = aP2_USU_CLA;
         this.AV12USU_INT = aP3_USU_INT;
         this.AV13USU_MAIW = aP4_USU_MAIW;
         this.AV11Modo = aP5_Modo;
         initialize();
         executePrivate();
         aP0_USU_COD=this.AV8USU_COD;
         aP1_USU_DES=this.AV9USU_DES;
         aP2_USU_CLA=this.AV10USU_CLA;
         aP3_USU_INT=this.AV12USU_INT;
         aP4_USU_MAIW=this.AV13USU_MAIW;
         aP5_Modo=this.AV11Modo;
         return AV11Modo ;
      }

      public void executeSubmit( ref String aP0_USU_COD ,
                                 ref String aP1_USU_DES ,
                                 ref String aP2_USU_CLA ,
                                 ref String aP3_USU_INT ,
                                 ref String aP4_USU_MAIW ,
                                 ref String aP5_Modo )
      {
         ptbusseg1 objptbusseg1;
         objptbusseg1 = new ptbusseg1();
         objptbusseg1.AV8USU_COD = aP0_USU_COD;
         objptbusseg1.AV9USU_DES = aP1_USU_DES;
         objptbusseg1.AV10USU_CLA = aP2_USU_CLA;
         objptbusseg1.AV12USU_INT = aP3_USU_INT;
         objptbusseg1.AV13USU_MAIW = aP4_USU_MAIW;
         objptbusseg1.AV11Modo = aP5_Modo;
         objptbusseg1.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbusseg1.executePrivateCatch ));
         aP0_USU_COD=this.AV8USU_COD;
         aP1_USU_DES=this.AV9USU_DES;
         aP2_USU_CLA=this.AV10USU_CLA;
         aP3_USU_INT=this.AV12USU_INT;
         aP4_USU_MAIW=this.AV13USU_MAIW;
         aP5_Modo=this.AV11Modo;
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
         if ( StringUtil.StrCmp(AV11Modo, "INS") == 0 )
         {
            /*
               INSERT RECORD ON TABLE SEG002

            */
            A6USU_COD = AV8USU_COD ;
            A7USU_DES = AV9USU_DES ;
            A155USU_CLA = AV10USU_CLA ;
            A180USU_INT = AV12USU_INT ;
            n180USU_INT = false ;
            A249USU_MAIW = AV13USU_MAIW ;
            n249USU_MAIW = false ;
            /* Using cursor P002M2 */
            pr_default.execute(0, new Object[] {A6USU_COD, A7USU_DES, A155USU_CLA, n180USU_INT, A180USU_INT, n249USU_MAIW, A249USU_MAIW});
            pr_default.close(0);
            if ( (pr_default.getStatus(0) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(context.GetMessage( "GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
         }
         else if ( StringUtil.StrCmp(AV11Modo, "UPD") == 0 )
         {
            /* Optimized UPDATE. */
            /* Using cursor P002M3 */
            pr_default.execute(1, new Object[] {AV9USU_DES, AV10USU_CLA, n180USU_INT, AV12USU_INT, n249USU_MAIW, AV13USU_MAIW, AV8USU_COD});
            pr_default.close(1);
            /* End optimized UPDATE. */
         }
         else if ( StringUtil.StrCmp(AV11Modo, "DLT") == 0 )
         {
            /* Optimized DELETE. */
            /* Using cursor P002M4 */
            pr_default.execute(2, new Object[] {AV8USU_COD});
            pr_default.close(2);
            /* End optimized DELETE. */
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUSSEG1");
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
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         A155USU_CLA = "" ;
         A180USU_INT = "" ;
         A249USU_MAIW = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbusseg1__default(),
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

      private int GX_INS15 ;
      private String AV8USU_COD ;
      private String AV9USU_DES ;
      private String AV10USU_CLA ;
      private String AV12USU_INT ;
      private String AV11Modo ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String A155USU_CLA ;
      private String A180USU_INT ;
      private String Gx_emsg ;
      private bool n180USU_INT ;
      private bool n249USU_MAIW ;
      private String AV13USU_MAIW ;
      private String A249USU_MAIW ;
      private IGxDataStore dsDefault ;
      private String aP0_USU_COD ;
      private String aP1_USU_DES ;
      private String aP2_USU_CLA ;
      private String aP3_USU_INT ;
      private String aP4_USU_MAIW ;
      private String aP5_Modo ;
      private IDataStoreProvider pr_default ;
   }

   public class ptbusseg1__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP002M2 ;
          prmP002M2 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@USU_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@USU_CLA",SqlDbType.Char,20,0} ,
          new Object[] {"@USU_INT",SqlDbType.Char,10,0} ,
          new Object[] {"@USU_MAIW",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmP002M3 ;
          prmP002M3 = new Object[] {
          new Object[] {"@USU_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@USU_CLA",SqlDbType.Char,20,0} ,
          new Object[] {"@USU_INT",SqlDbType.Char,10,0} ,
          new Object[] {"@USU_MAIW",SqlDbType.VarChar,256,0} ,
          new Object[] {"@AV8USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmP002M4 ;
          prmP002M4 = new Object[] {
          new Object[] {"@AV8USU_COD",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002M2", "INSERT INTO [SEG002] ([USU_COD], [USU_DES], [USU_CLA], [USU_INT], [USU_MAIW]) VALUES (@USU_COD, @USU_DES, @USU_CLA, @USU_INT, @USU_MAIW)", GxErrorMask.GX_NOMASK,prmP002M2)
             ,new CursorDef("P002M3", "UPDATE [SEG002] SET [USU_DES]=@USU_DES, [USU_CLA]=@USU_CLA, [USU_INT]=@USU_INT, [USU_MAIW]=@USU_MAIW  WHERE [USU_COD] = @AV8USU_COD", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002M3)
             ,new CursorDef("P002M4", "DELETE FROM [SEG002]  WHERE [USU_COD] = @AV8USU_COD", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002M4)
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
                stmt.SetParameter(3, (String)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[6]);
                }
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                stmt.SetParameter(5, (String)parms[6]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
