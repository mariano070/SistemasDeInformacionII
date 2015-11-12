/*
               File: HMASTER_SEG_CK
        Description: MASTER PAGE SEGURIDAD COOKIE
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:18:21.85
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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class hmaster_seg_ck : GXMasterPage, System.Web.SessionState.IRequiresSessionState
   {
      public hmaster_seg_ck( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public hmaster_seg_ck( IGxContext context )
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
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         context.SetTheme("Modern");
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            PA332( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               WS332( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE332( ) ;
               }
            }
         }
         this.cleanup();
      }

      protected void RenderHtmlHeaders( )
      {
         getDataAreaObject().RenderHtmlHeaders();
      }

      protected void RenderHtmlOpenForm( )
      {
         getDataAreaObject().RenderHtmlOpenForm();
      }

      protected void RenderHtmlCloseForm332( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         getDataAreaObject().RenderHtmlCloseForm();
         context.AddJavascriptSource("hmaster_seg_ck.js", "?11182186");
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
      }

      protected void WB330( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            if ( ! ShowMPWhenPopUp( ) && context.isPopUpObject( ) )
            {
               getDataAreaObject().RenderHtmlContent();
               return  ;
            }
            context.WriteHtmlText( "<p>") ;
            wb_table1_3_332( true) ;
         }
         else
         {
            wb_table1_3_332( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_332e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</p>") ;
         }
         wbLoad = true ;
      }

      protected void START332( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP330( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( getDataAreaObject().ExecuteStartEvent() != 0 )
            {
               setAjaxCallMode();
            }
         }
      }

      protected void WS332( )
      {
         START332( ) ;
         EVT332( ) ;
      }

      protected void EVT332( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName") ;
               EvtGridId = cgiGet( "_EventGridId") ;
               EvtRowId = cgiGet( "_EventRowId") ;
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1) ;
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( StringUtil.StrCmp(sEvt, "RFR_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "START_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E11332 */
                           E11332 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E12332 */
                           E12332 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           if ( ! wbErr )
                           {
                              Rfr0gs = false ;
                              if ( ! Rfr0gs )
                              {
                              }
                              dynload_actions( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  if ( context.wbHandled == 0 )
                  {
                     getDataAreaObject().DispatchEvents();
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void WE332( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm332( ) ;
            }
         }
      }

      protected void PA332( )
      {
         if ( nDonePA == 0 )
         {
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF332( ) ;
         /* End function Refresh */
      }

      protected void RF332( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H00332 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               A117PRG_WEB = H00332_A117PRG_WEB[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", true, "A117PRG_WEB", A117PRG_WEB);
               /* Execute user event: E12332 */
               E12332 ();
               pr_default.readNext(0);
            }
            pr_default.close(0);
            WB330( ) ;
         }
      }

      protected void STRUP330( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11332 */
         E11332 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E11332 */
         E11332 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11332( )
      {
         /* Start Routine */
         AV15PRG_WEB = "HSEG000.ASPX" ;
         AV16SIS_DES = "SEGURIDAD" ;
         AV20PROGRAMA = "HSEG000" ;
         AV19K_USUARIO = "HSEG000_USUARIO" ;
         AV18K_SESION = "HSEG000_SESION" ;
         AV17K_CADUCA = "HSEG000_CADUCA" ;
         lblDesc_programa_Caption = Contholder1.Pgmdesc ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblDesc_programa_Internalname, "Caption", lblDesc_programa_Caption);
         AV9TEXTO = "txt" + AV8SESION.Get(AV19K_USUARIO) + AV8SESION.Get(AV18K_SESION) + AV8SESION.Get(AV17K_CADUCA) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV12USUARIO)) )
         {
            AV12USUARIO = AV8SESION.Get(AV19K_USUARIO) ;
         }
         AV13ID_SESION = (int)(NumberUtil.Val( AV8SESION.Get(AV18K_SESION), ".")) ;
         AV10NOM_COOKIE = "KEY_" + StringUtil.Trim( AV15PRG_WEB) + "_" + StringUtil.Trim( AV12USUARIO) ;
         AV11VAL_COOKIE = context.GetCookie( AV10NOM_COOKIE) ;
         AV9TEXTO = "NOM_COOK:" + StringUtil.Trim( AV10NOM_COOKIE) + " VAL:" + AV11VAL_COOKIE + "  SS:" + AV8SESION.Get(AV18K_SESION) ;
         AV9TEXTO = "cphold" + Contholder1.Pgmname + "  &programa:" + AV20PROGRAMA ;
         if ( ( ( ( StringUtil.StrCmp(AV11VAL_COOKIE, AV8SESION.Get(AV18K_SESION)) == 0 ) ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV11VAL_COOKIE)) ) || ( StringUtil.StrCmp(Contholder1.Pgmname, AV20PROGRAMA) == 0 ) )
         {
            AV8SESION.Set(AV19K_USUARIO, AV12USUARIO);
            AV8SESION.Set(AV18K_SESION, AV11VAL_COOKIE);
            AV8SESION.Set(AV17K_CADUCA, StringUtil.Str( (decimal)(30), 10, 0));
            AV21PRS_NRO = (int)(NumberUtil.Int( (long)(NumberUtil.Random( )*10000000))) ;
            AV10NOM_COOKIE = "KEY_" + StringUtil.Trim( A117PRG_WEB) + "_" + StringUtil.Trim( AV12USUARIO) ;
            AV14A = context.SetCookie( AV10NOM_COOKIE, StringUtil.Str( (decimal)(AV21PRS_NRO), 10, 0), "", (DateTime)(DateTime.MinValue), "", 0) ;
            AV22INDICE = StringUtil.Trim( A117PRG_WEB) + "_USUARIO" ;
            AV8SESION.Set(AV22INDICE, AV12USUARIO);
            AV5LINK = StringUtil.Trim( AV15PRG_WEB) + "?" + StringUtil.Trim( AV16SIS_DES) + "," + StringUtil.Trim( AV12USUARIO) + "," + StringUtil.Trim( StringUtil.Str( (decimal)(AV21PRS_NRO), 10, 0)) ;
            lblVolver_menu_Link = formatLink(AV5LINK)  ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblVolver_menu_Internalname, "Link", lblVolver_menu_Link);
         }
         else
         {
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E12332( )
      {
         /* Load Routine */
      }

      protected void wb_table1_3_332( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" background=\""+context.convertURL( context.GetImagePath( "60f011bb-ebb0-4dc6-81bc-682e5a2133f1", "", "Modern"))+"\"  style=\"text-align:"+context.GetCssProperty( "Align", "right")+";height:75px;width:780px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblVolver_menu_Internalname, 1, 1, 0, "Volver al Menú Seguridad", "", lblVolver_menu_Link, "", 0, lblVolver_menu_Jsonclick, "E_MPAGE.", StyleString, ClassString, "HLP_HMASTER_SEG_CK.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\"  style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            /* Text block */
            ClassString = "menu" ;
            StyleString = "font-family:'Verdana'; font-size:11.0pt; font-weight:bold; font-style:normal; color:#008080" ;
            GxWebStd.gx_label_ctrl( context, lblDesc_programa_Internalname, 1, 1, 0, lblDesc_programa_Caption, "", "", "", 0, lblDesc_programa_Jsonclick, "E_MPAGE.", StyleString, ClassString, "HLP_HMASTER_SEG_CK.htm");
            getDataAreaObject().RenderHtmlContent();
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_332e( true) ;
         }
         else
         {
            wb_table1_3_332e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         context.SetWrapped(true);
         PA332( ) ;
         WS332( ) ;
         WE332( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void master_styles( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= getDataAreaObject().GetForm().Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( getDataAreaObject().GetForm().Jscriptsrc.Item(idxLst)), "?11182196");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("hmaster_seg_ck.js", "?11182196");
         }
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblVolver_menu_Internalname = "VOLVER_MENU_MPAGE" ;
         lblDesc_programa_Internalname = "DESC_PROGRAMA_MPAGE" ;
         tblTable1_Internalname = "TABLE1_MPAGE" ;
         getDataAreaObject().GetForm().Internalname = "FORM_MPAGE" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         lblVolver_menu_Link = "" ;
         lblDesc_programa_Caption = " " ;
         Contholder1.setDataArea(getDataAreaObject());
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         Contholder1 = new GXDataAreaControl();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         scmdbuf = "" ;
         H00332_A126PRG_COD = new short[1] ;
         H00332_A117PRG_WEB = new String[] {""} ;
         A117PRG_WEB = "" ;
         AV15PRG_WEB = "" ;
         AV16SIS_DES = "" ;
         AV20PROGRAMA = "" ;
         AV19K_USUARIO = "" ;
         AV18K_SESION = "" ;
         AV17K_CADUCA = "" ;
         AV9TEXTO = "" ;
         AV8SESION = new GxWebSession( context);
         AV12USUARIO = "" ;
         AV10NOM_COOKIE = "" ;
         AV11VAL_COOKIE = "" ;
         AV22INDICE = "" ;
         AV5LINK = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblVolver_menu_Jsonclick = "" ;
         GXt_char1 = "" ;
         lblDesc_programa_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sDynURL = "" ;
         Form = new GXWebForm();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.hmaster_seg_ck__default(),
            new Object[][] {
                new Object[] {
               H00332_A126PRG_COD, H00332_A117PRG_WEB
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short initialized ;
      private short GxWebError ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short AV14A ;
      private short nGotPars ;
      private short nGXWrapped ;
      private int AV13ID_SESION ;
      private int AV21PRS_NRO ;
      private int idxLst ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String A117PRG_WEB ;
      private String AV15PRG_WEB ;
      private String AV16SIS_DES ;
      private String AV20PROGRAMA ;
      private String AV19K_USUARIO ;
      private String AV18K_SESION ;
      private String AV17K_CADUCA ;
      private String lblDesc_programa_Caption ;
      private String lblDesc_programa_Internalname ;
      private String AV9TEXTO ;
      private String AV12USUARIO ;
      private String AV10NOM_COOKIE ;
      private String AV11VAL_COOKIE ;
      private String AV5LINK ;
      private String lblVolver_menu_Link ;
      private String lblVolver_menu_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblVolver_menu_Jsonclick ;
      private String GXt_char1 ;
      private String lblDesc_programa_Jsonclick ;
      private String sDynURL ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV22INDICE ;
      private GxWebSession AV8SESION ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private GXDataAreaControl Contholder1 ;
      private IDataStoreProvider pr_default ;
      private short[] H00332_A126PRG_COD ;
      private String[] H00332_A117PRG_WEB ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class hmaster_seg_ck__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00332 ;
          prmH00332 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H00332", "SELECT [PRG_COD], [PRG_WEB] FROM [SEG001] WITH (NOLOCK) ORDER BY [PRG_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00332,100,1,false,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
