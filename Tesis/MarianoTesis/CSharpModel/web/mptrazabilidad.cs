/*
               File: MPTrazabilidad
        Description: MPTurismo
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:55.44
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
   public class mptrazabilidad : GXMasterPage, System.Web.SessionState.IRequiresSessionState
   {
      public mptrazabilidad( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public mptrazabilidad( IGxContext context )
      {
         this.context = context;
         IsMain = false;
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
            PA012( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               WS012( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE012( ) ;
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

      protected void RenderHtmlCloseForm012( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "vTABSMENUDATA_MPAGE", (Object)(AV12TabsMenuData));
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTABSMENUDATA_MPAGE", (Object)(AV12TabsMenuData));
         }
         GxWebStd.gx_hidden_field( context, "DROPDOWNTABSMENU1_MPAGE_Width", StringUtil.RTrim( Dropdowntabsmenu1_Width));
         GxWebStd.gx_hidden_field( context, "DROPDOWNTABSMENU1_MPAGE_Height", StringUtil.RTrim( Dropdowntabsmenu1_Height));
         GxWebStd.gx_hidden_field( context, "DROPDOWNTABSMENU1_MPAGE_Menustyle", StringUtil.RTrim( Dropdowntabsmenu1_Menustyle));
         getDataAreaObject().RenderHtmlCloseForm();
         if ( ! ( WebComp_Wcseguridad == null ) )
         {
            WebComp_Wcseguridad.componentjscripts();
         }
         if ( ! ( WebComp_Wcrecentlinks == null ) )
         {
            WebComp_Wcrecentlinks.componentjscripts();
         }
         context.AddJavascriptSource("DropDownTabsMenu/dropdowntabs.js", "");
         context.AddJavascriptSource("DropDownTabsMenu/DropDownTabsMenuRender.js", "");
         context.AddJavascriptSource("mptrazabilidad.js", "?19295547");
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
      }

      protected void WB010( )
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
            wb_table1_2_012( true) ;
         }
         else
         {
            wb_table1_2_012( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<p></p>") ;
         }
         wbLoad = true ;
      }

      protected void START012( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            OldWcseguridad = cgiGet( "MPW0028") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wcseguridad_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWcseguridad)) )
            {
               WebComp_Wcseguridad = getWebComponent(GetType(), "GeneXus.Programs", OldWcseguridad, new Object[] {context} );
               WebComp_Wcseguridad.ComponentInit();
               WebComp_Wcseguridad.Name = "OldWcseguridad";
               WebComp_Wcseguridad_Component = OldWcseguridad ;
               WebComp_Wcseguridad.componentrestorestate("MPW0028", "");
            }
            OldWcrecentlinks = cgiGet( "MPW0037") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wcrecentlinks_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWcrecentlinks)) )
            {
               WebComp_Wcrecentlinks = getWebComponent(GetType(), "GeneXus.Programs", OldWcrecentlinks, new Object[] {context} );
               WebComp_Wcrecentlinks.ComponentInit();
               WebComp_Wcrecentlinks.Name = "OldWcrecentlinks";
               WebComp_Wcrecentlinks_Component = OldWcrecentlinks ;
               WebComp_Wcrecentlinks.componentrestorestate("MPW0037", "");
            }
         }
         wbErr = false ;
         STRUP010( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( getDataAreaObject().ExecuteStartEvent() != 0 )
            {
               setAjaxCallMode();
            }
         }
      }

      protected void WS012( )
      {
         START012( ) ;
         EVT012( ) ;
      }

      protected void EVT012( )
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
                           /* Execute user event: E11012 */
                           E11012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "REFRESH_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E12012 */
                           E12012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DESCONECTAR_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E13012 */
                           E13012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "CAMBIAR CONTRASEñA_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E14012 */
                           E14012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E15012 */
                           E15012 ();
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
                  else if ( StringUtil.StrCmp(sEvtType, "M") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-2)) ;
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-6)) ;
                     nCmpId = (short)(NumberUtil.Val( sEvtType, ".")) ;
                     if ( nCmpId == 28 )
                     {
                        OldWcseguridad = cgiGet( "MPW0028") ;
                        if ( ( StringUtil.Len( OldWcseguridad) == 0 ) || ( StringUtil.StrCmp(OldWcseguridad, WebComp_Wcseguridad_Component) != 0 ) )
                        {
                           WebComp_Wcseguridad = getWebComponent(GetType(), "GeneXus.Programs", OldWcseguridad, new Object[] {context} );
                           WebComp_Wcseguridad.ComponentInit();
                           WebComp_Wcseguridad.Name = "OldWcseguridad";
                           WebComp_Wcseguridad_Component = OldWcseguridad ;
                        }
                        if ( StringUtil.Len( WebComp_Wcseguridad_Component) != 0 )
                        {
                           WebComp_Wcseguridad.componentprocess("MPW0028", "", sEvt);
                        }
                        WebComp_Wcseguridad_Component = OldWcseguridad ;
                     }
                     else if ( nCmpId == 37 )
                     {
                        OldWcrecentlinks = cgiGet( "MPW0037") ;
                        if ( ( StringUtil.Len( OldWcrecentlinks) == 0 ) || ( StringUtil.StrCmp(OldWcrecentlinks, WebComp_Wcrecentlinks_Component) != 0 ) )
                        {
                           WebComp_Wcrecentlinks = getWebComponent(GetType(), "GeneXus.Programs", OldWcrecentlinks, new Object[] {context} );
                           WebComp_Wcrecentlinks.ComponentInit();
                           WebComp_Wcrecentlinks.Name = "OldWcrecentlinks";
                           WebComp_Wcrecentlinks_Component = OldWcrecentlinks ;
                        }
                        if ( StringUtil.Len( WebComp_Wcrecentlinks_Component) != 0 )
                        {
                           WebComp_Wcrecentlinks.componentprocess("MPW0037", "", sEvt);
                        }
                        WebComp_Wcrecentlinks_Component = OldWcrecentlinks ;
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

      protected void WE012( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm012( ) ;
            }
         }
      }

      protected void PA012( )
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
         RF012( ) ;
         /* End function Refresh */
      }

      protected void RF012( )
      {
         /* Execute user event: E12012 */
         E12012 ();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( StringUtil.StrCmp(WebComp_Wcseguridad_Component, "") == 0 )
            {
               WebComp_Wcseguridad = getWebComponent(GetType(), "GeneXus.Programs", "wcseguridad", new Object[] {context} );
               WebComp_Wcseguridad.ComponentInit();
               WebComp_Wcseguridad.Name = "WCSEGURIDAD";
               WebComp_Wcseguridad_Component = "WCSEGURIDAD" ;
            }
            if ( ( StringUtil.StrCmp(OldWcseguridad, WebComp_Wcseguridad_Component) != 0 ) && ( StringUtil.StrCmp(WebComp_Wcseguridad_Component, "WCSEGURIDAD") == 0 ) )
            {
               WebComp_Wcseguridad.setjustcreated();
            }
            if ( ( StringUtil.Len( WebComp_Wcseguridad_Component) != 0 ) && ( StringUtil.StrCmp(WebComp_Wcseguridad_Component, "WCSEGURIDAD") == 0 ) )
            {
               WebComp_Wcseguridad.componentprepare(new Object[] {(String)"MPW0028",(String)"",(String)AV5PRG_WEB});
               WebComp_Wcseguridad.componentbind(new Object[] {(String)""});
            }
            if ( WebComp_Wcseguridad_Visible != 0 )
            {
               if ( StringUtil.Len( WebComp_Wcseguridad_Component) != 0 )
               {
                  WebComp_Wcseguridad.componentstart();
               }
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Wcrecentlinks_Component) != 0 )
               {
                  WebComp_Wcrecentlinks.componentstart();
               }
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E15012 */
            E15012 ();
            WB010( ) ;
         }
      }

      protected void STRUP010( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11012 */
         E11012 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vTABSMENUDATA_MPAGE"), (Object)(AV12TabsMenuData));
            /* Read variables values. */
            /* Read saved values. */
            OldWcseguridad = cgiGet( "MPW0028") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wcseguridad_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWcseguridad)) )
            {
               WebComp_Wcseguridad = getWebComponent(GetType(), "GeneXus.Programs", OldWcseguridad, new Object[] {context} );
               WebComp_Wcseguridad.ComponentInit();
               WebComp_Wcseguridad.Name = "OldWcseguridad";
               WebComp_Wcseguridad_Component = OldWcseguridad ;
               WebComp_Wcseguridad.componentrestorestate("MPW0028", "");
            }
            OldWcrecentlinks = cgiGet( "MPW0037") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wcrecentlinks_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWcrecentlinks)) )
            {
               WebComp_Wcrecentlinks = getWebComponent(GetType(), "GeneXus.Programs", OldWcrecentlinks, new Object[] {context} );
               WebComp_Wcrecentlinks.ComponentInit();
               WebComp_Wcrecentlinks.Name = "OldWcrecentlinks";
               WebComp_Wcrecentlinks_Component = OldWcrecentlinks ;
               WebComp_Wcrecentlinks.componentrestorestate("MPW0037", "");
            }
            Dropdowntabsmenu1_Width = cgiGet( "DROPDOWNTABSMENU1_MPAGE_Width") ;
            Dropdowntabsmenu1_Height = cgiGet( "DROPDOWNTABSMENU1_MPAGE_Height") ;
            Dropdowntabsmenu1_Menustyle = cgiGet( "DROPDOWNTABSMENU1_MPAGE_Menustyle") ;
            Dropdowntabsmenu1_Visible = StringUtil.StrToBool( cgiGet( "DROPDOWNTABSMENU1_MPAGE_Visible")) ;
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
         /* Execute user event: E11012 */
         E11012 ();
         if (returnInSub) return;
      }

      protected void E11012( )
      {
         /* Start Routine */
         /* Execute user subroutine: S112 */
         S112 ();
         if (returnInSub) return;
         WebComp_Wcseguridad_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, "gxHTMLWrpMPW0028"+"", "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(WebComp_Wcseguridad_Visible), 5, 0)));
         bttBtn_desconectar_Visible = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, bttBtn_desconectar_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_desconectar_Visible), 5, 0)));
         bttBtn_cambioclave_Visible = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, bttBtn_cambioclave_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_cambioclave_Visible), 5, 0)));
         lblTxtusr_Visible = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblTxtusr_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblTxtusr_Visible), 5, 0)));
         lblUsuario_Visible = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblUsuario_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblUsuario_Visible), 5, 0)));
         /* Execute user subroutine: S122 */
         S122 ();
         if (returnInSub) return;
         tblTable2_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, tblTable2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTable2_Visible), 5, 0)));
         lblHome_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblHome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblHome_Visible), 5, 0)));
         lblFirsttext_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblFirsttext_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblFirsttext_Visible), 5, 0)));
         lblSecondtext_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblSecondtext_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblSecondtext_Visible), 5, 0)));
         lblThirdtext_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblThirdtext_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblThirdtext_Visible), 5, 0)));
         lblFourthtext_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblFourthtext_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblFourthtext_Visible), 5, 0)));
         lblFifthtext_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblFifthtext_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblFifthtext_Visible), 5, 0)));
         new loadcontext(context ).execute( out  AV6Context) ;
         lblUsuario_Caption = AV6Context.gxTpr_User ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblUsuario_Internalname, "Caption", lblUsuario_Caption);
         AV5PRG_WEB = "HTBUS000.aspx" ;
         new isauthorizedmp(context ).execute(  AV5PRG_WEB,  Contentholder.Pgmname, out  AV11IsAuthorized) ;
         lblPrg_desc_Caption = "" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblPrg_desc_Internalname, "Caption", lblPrg_desc_Caption);
         if ( ! AV11IsAuthorized )
         {
            lblMensajes_Caption = AV5PRG_WEB+Contentholder.Pgmname+AV6Context.gxTpr_User ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblMensajes_Internalname, "Caption", lblMensajes_Caption);
            /* Object Property */
            if ( StringUtil.StrCmp(WebComp_Wcseguridad_Component, "WCSEGURIDAD") != 0 )
            {
               WebComp_Wcseguridad = getWebComponent(GetType(), "GeneXus.Programs", "wcseguridad", new Object[] {context} );
               WebComp_Wcseguridad.ComponentInit();
               WebComp_Wcseguridad.Name = "WCSEGURIDAD";
               WebComp_Wcseguridad_Component = "WCSEGURIDAD" ;
            }
            if ( StringUtil.StrCmp(OldWcseguridad, WebComp_Wcseguridad_Component) != 0 )
            {
               WebComp_Wcseguridad.setjustcreated();
            }
            if ( StringUtil.Len( WebComp_Wcseguridad_Component) != 0 )
            {
               WebComp_Wcseguridad.componentprepare(new Object[] {(String)"MPW0028",(String)"",(String)AV5PRG_WEB});
               WebComp_Wcseguridad.componentbind(new Object[] {(String)""});
            }
            WebComp_Wcseguridad_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, "gxHTMLWrpMPW0028"+"", "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(WebComp_Wcseguridad_Visible), 5, 0)));
            bttBtn_desconectar_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, bttBtn_desconectar_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_desconectar_Visible), 5, 0)));
            bttBtn_cambioclave_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, bttBtn_cambioclave_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_cambioclave_Visible), 5, 0)));
            lblTxtusr_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblTxtusr_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblTxtusr_Visible), 5, 0)));
            lblUsuario_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblUsuario_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblUsuario_Visible), 5, 0)));
            new isauthorizedmp(context ).execute(  AV5PRG_WEB,  Contentholder.Pgmname, out  AV11IsAuthorized) ;
            if ( ! AV11IsAuthorized )
            {
               tblTablemenu_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, tblTablemenu_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemenu_Visible), 5, 0)));
               tblTablecontent_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, tblTablecontent_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablecontent_Visible), 5, 0)));
            }
            else
            {
               lblMensajes_Caption = "Autorizado" ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblMensajes_Internalname, "Caption", lblMensajes_Caption);
               tblTablemenu_Visible = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, tblTablemenu_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemenu_Visible), 5, 0)));
               tblTablecontent_Visible = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, tblTablecontent_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablecontent_Visible), 5, 0)));
               lblPrg_desc_Caption = Contentholder.Pgmdesc ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblPrg_desc_Internalname, "Caption", lblPrg_desc_Caption);
            }
         }
         else
         {
            lblMensajes_Caption = "Autorizado" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblMensajes_Internalname, "Caption", lblMensajes_Caption);
            tblTablemenu_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, tblTablemenu_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemenu_Visible), 5, 0)));
            tblTablecontent_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, tblTablecontent_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablecontent_Visible), 5, 0)));
            lblPrg_desc_Caption = Contentholder.Pgmdesc ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblPrg_desc_Internalname, "Caption", lblPrg_desc_Caption);
         }
      }

      protected void E12012( )
      {
         /* Refresh Routine */
         /* Object Property */
         if ( StringUtil.StrCmp(WebComp_Wcrecentlinks_Component, "RecentLinks") != 0 )
         {
            WebComp_Wcrecentlinks = getWebComponent(GetType(), "GeneXus.Programs", "recentlinks", new Object[] {context} );
            WebComp_Wcrecentlinks.ComponentInit();
            WebComp_Wcrecentlinks.Name = "RecentLinks";
            WebComp_Wcrecentlinks_Component = "RecentLinks" ;
         }
         if ( StringUtil.StrCmp(OldWcrecentlinks, WebComp_Wcrecentlinks_Component) != 0 )
         {
            WebComp_Wcrecentlinks.setjustcreated();
         }
         if ( StringUtil.Len( WebComp_Wcrecentlinks_Component) != 0 )
         {
            WebComp_Wcrecentlinks.componentprepare(new Object[] {(String)"MPW0037",(String)"",getDataAreaObject().GetForm().Caption,Contentholder.Pgmname});
            WebComp_Wcrecentlinks.componentbind(new Object[] {(String)"",(String)""});
         }
      }

      protected void E13012( )
      {
         /* 'Desconectar' Routine */
         AV6Context.gxTpr_User = "" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "AV6Context", (Object)(AV6Context));
         new setcontext(context ).execute(  AV6Context) ;
         context.wjLoc = formatLink("htbus000.aspx")  ;
      }

      protected void E14012( )
      {
         /* 'Cambiar Contraseña' Routine */
         new loadcontext(context ).execute( out  AV6Context) ;
         AV23USUARIO = StringUtil.Upper( AV6Context.gxTpr_User) ;
         context.PopUp(formatLink("hcambio_password.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV23USUARIO)), new Object[] {"AV23USUARIO"});
      }

      protected void S122( )
      {
         /* 'DROPDOWNTABSMENUSAMPLE' Routine */
         GXt_objcol_SdtTabsMenuData_TabsMenuDataItem2 = AV12TabsMenuData ;
         new dptabsmenutrazabilidad(context ).execute(  AV24SISTEMA,  AV23USUARIO, out  GXt_objcol_SdtTabsMenuData_TabsMenuDataItem2) ;
         AV12TabsMenuData = GXt_objcol_SdtTabsMenuData_TabsMenuDataItem2 ;
      }

      protected void S112( )
      {
         /* 'PRIMER USUARIO SISTEMA' Routine */
         AV25cant_usu = 0 ;
         /* Using cursor H00012 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A7USU_DES = H00012_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "A7USU_DES", A7USU_DES);
            A6USU_COD = H00012_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "A6USU_COD", A6USU_COD);
            AV25cant_usu = (short)(AV25cant_usu+1) ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV25cant_usu == 0 )
         {
            /* Window Datatype Object Property */
            AV26window.Url = formatLink("htbusseg0_ini.aspx")  ;
            AV26window.SetReturnParms(new Object[] {});
            AV26window.Height = 300 ;
            AV26window.Width = 550 ;
            context.NewWindow(AV26window);
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E15012( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable6_Internalname, tblTable6_Internalname, "", "Table95", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            wb_table2_5_012( true) ;
         }
         else
         {
            wb_table2_5_012( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\"  style=\"height:14px\">") ;
            wb_table3_33_012( true) ;
         }
         else
         {
            wb_table3_33_012( false) ;
         }
         return  ;
      }

      protected void wb_table3_33_012e( bool wbgen )
      {
         if ( wbgen )
         {
            /* WebComponent */
            GxWebStd.gx_hidden_field( context, "MPW0037"+"", StringUtil.RTrim( WebComp_Wcrecentlinks_Component));
            context.WriteHtmlText( "<div") ;
            context.WriteHtmlText( " id=\""+"gxHTMLWrpMPW0037"+""+"\""+"") ;
            context.WriteHtmlText( ">") ;
            if ( StringUtil.Len( WebComp_Wcrecentlinks_Component) != 0 )
            {
               if ( StringUtil.StrCmp(OldWcrecentlinks, WebComp_Wcrecentlinks_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpMPW0037"+"");
               }
               WebComp_Wcrecentlinks.componentdraw();
               if ( StringUtil.StrCmp(OldWcrecentlinks, WebComp_Wcrecentlinks_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspEndCmp();
               }
            }
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\"  style=\"height:13px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:11.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblPrg_desc_Internalname, 1, 1, 0, lblPrg_desc_Caption, "", "", "", 0, lblPrg_desc_Jsonclick, "E_MPAGE.", StyleString, ClassString, "HLP_MPTrazabilidad.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:34px;width:0px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"width:100%\">") ;
            wb_table4_44_012( true) ;
         }
         else
         {
            wb_table4_44_012( false) ;
         }
         return  ;
      }

      protected void wb_table4_44_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"width:0px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\"  style=\"height:132px\">") ;
            wb_table5_51_012( true) ;
         }
         else
         {
            wb_table5_51_012( false) ;
         }
         return  ;
      }

      protected void wb_table5_51_012e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table6_54_012( true) ;
         }
         else
         {
            wb_table6_54_012( false) ;
         }
         return  ;
      }

      protected void wb_table6_54_012e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table7_57_012( true) ;
         }
         else
         {
            wb_table7_57_012( false) ;
         }
         return  ;
      }

      protected void wb_table7_57_012e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table8_60_012( true) ;
         }
         else
         {
            wb_table8_60_012( false) ;
         }
         return  ;
      }

      protected void wb_table8_60_012e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table9_65_012( true) ;
         }
         else
         {
            wb_table9_65_012( false) ;
         }
         return  ;
      }

      protected void wb_table9_65_012e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table10_68_012( true) ;
         }
         else
         {
            wb_table10_68_012( false) ;
         }
         return  ;
      }

      protected void wb_table10_68_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_012e( true) ;
         }
         else
         {
            wb_table1_2_012e( false) ;
         }
      }

      protected void wb_table10_68_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable11_Internalname, tblTable11_Internalname, "", "HorizontalLine", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table11_71_012( true) ;
         }
         else
         {
            wb_table11_71_012( false) ;
         }
         return  ;
      }

      protected void wb_table11_71_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table10_68_012e( true) ;
         }
         else
         {
            wb_table10_68_012e( false) ;
         }
      }

      protected void wb_table11_71_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            if ( tblTable2_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;" ;
            }
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(100), 10, 0)) + "%" + ";" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "TableTopMenu", 0, "", "", 1, 2, sStyleString, "none", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"width:42px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblHome_Internalname, lblHome_Visible, 1, 0, "Home", "", "", "", 0, lblHome_Jsonclick, "E_MPAGE.", StyleString, ClassString, "HLP_MPTrazabilidad.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"width:85px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblFirsttext_Internalname, lblFirsttext_Visible, 1, 0, "First Option", "", "", "", 0, lblFirsttext_Jsonclick, "E_MPAGE.", StyleString, ClassString, "HLP_MPTrazabilidad.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"width:101px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblSecondtext_Internalname, lblSecondtext_Visible, 1, 0, "Second Option", "", "", "", 0, lblSecondtext_Jsonclick, "E_MPAGE.", StyleString, ClassString, "HLP_MPTrazabilidad.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"width:90px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblThirdtext_Internalname, lblThirdtext_Visible, 1, 0, "Third Option", "", "", "", 0, lblThirdtext_Jsonclick, "E_MPAGE.", StyleString, ClassString, "HLP_MPTrazabilidad.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblFourthtext_Internalname, lblFourthtext_Visible, 1, 0, "Fourth Option", "", "", "", 0, lblFourthtext_Jsonclick, "E_MPAGE.", StyleString, ClassString, "HLP_MPTrazabilidad.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblFifthtext_Internalname, lblFifthtext_Visible, 1, 0, "Last One", "", "", "", 0, lblFifthtext_Jsonclick, "E_MPAGE.", StyleString, ClassString, "HLP_MPTrazabilidad.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table11_71_012e( true) ;
         }
         else
         {
            wb_table11_71_012e( false) ;
         }
      }

      protected void wb_table9_65_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable10_Internalname, tblTable10_Internalname, "", "HorizontalSpace", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table9_65_012e( true) ;
         }
         else
         {
            wb_table9_65_012e( false) ;
         }
      }

      protected void wb_table8_60_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "TableBottom", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr align=\"left\" >") ;
            context.WriteHtmlText( "<td colspan=\"2\"  style=\"text-align:"+context.GetCssProperty( "Align", "right")+";width:100%\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblMensajes_Internalname, 1, 1, 0, lblMensajes_Caption, "", "", "", 0, lblMensajes_Jsonclick, "E_MPAGE.", StyleString, ClassString, "HLP_MPTrazabilidad.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage3_Internalname, "", context.GetImagePath( "f5f8a0c4-001a-440a-877e-a7d6e67aefb3", "", "Modern"), "Modern", 1, 1, "", "", 0, 0, 79, "", 35, "", 0, 0, "", "", 0, "", "", StyleString, ClassString, "", "", "", "", "HLP_MPTrazabilidad.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table8_60_012e( true) ;
         }
         else
         {
            wb_table8_60_012e( false) ;
         }
      }

      protected void wb_table7_57_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable9_Internalname, tblTable9_Internalname, "", "HorizontalSpace", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table7_57_012e( true) ;
         }
         else
         {
            wb_table7_57_012e( false) ;
         }
      }

      protected void wb_table6_54_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable8_Internalname, tblTable8_Internalname, "", "HorizontalLine", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_54_012e( true) ;
         }
         else
         {
            wb_table6_54_012e( false) ;
         }
      }

      protected void wb_table5_51_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable7_Internalname, tblTable7_Internalname, "", "HorizontalSpace", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_51_012e( true) ;
         }
         else
         {
            wb_table5_51_012e( false) ;
         }
      }

      protected void wb_table4_44_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            if ( tblTablecontent_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;" ;
            }
            GxWebStd.gx_table_start( context, tblTablecontent_Internalname, tblTablecontent_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            getDataAreaObject().RenderHtmlContent();
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_44_012e( true) ;
         }
         else
         {
            wb_table4_44_012e( false) ;
         }
      }

      protected void wb_table3_33_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            if ( tblTablemenu_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;" ;
            }
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(34), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(100), 10, 0)) + "%" + ";" ;
            GxWebStd.gx_table_start( context, tblTablemenu_Internalname, tblTablemenu_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"MPDROPDOWNTABSMENU1Container"+"\"></div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_33_012e( true) ;
         }
         else
         {
            wb_table3_33_012e( false) ;
         }
      }

      protected void wb_table2_5_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "TableTop", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" bgcolor=\"#FFFFFF\"  style=\"width:220px\">") ;
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage2_Internalname, "", context.GetImagePath( "1382f836-ea82-4658-aa27-5d13e1b4b3fb", "", "Modern"), "Modern", 1, 1, "", "", 0, 0, 220, "", 99, "", 0, 0, "", "", 0, "", "", StyleString, ClassString, "", "", "", "", "HLP_MPTrazabilidad.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td valign=\"bottom\" >") ;
            wb_table12_10_012( true) ;
         }
         else
         {
            wb_table12_10_012( false) ;
         }
         return  ;
      }

      protected void wb_table12_10_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            /* Static images/pictures */
            ClassString = "HeaderImage1" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, "", context.GetImagePath( "7326b96a-20b7-4973-8d71-35094049767d", "", "Modern"), "Modern", 1, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 0, "", "", StyleString, ClassString, "", "", "", "", "HLP_MPTrazabilidad.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_012e( true) ;
         }
         else
         {
            wb_table2_5_012e( false) ;
         }
      }

      protected void wb_table12_10_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable5_Internalname, tblTable5_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table13_13_012( true) ;
         }
         else
         {
            wb_table13_13_012( false) ;
         }
         return  ;
      }

      protected void wb_table13_13_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* WebComponent */
            GxWebStd.gx_hidden_field( context, "MPW0028"+"", StringUtil.RTrim( WebComp_Wcseguridad_Component));
            context.WriteHtmlText( "<div") ;
            context.WriteHtmlText( " id=\""+"gxHTMLWrpMPW0028"+""+"\""+((WebComp_Wcseguridad_Visible==1) ? "" : " style=\"display:none;\"")) ;
            context.WriteHtmlText( ">") ;
            if ( StringUtil.Len( WebComp_Wcseguridad_Component) != 0 )
            {
               if ( StringUtil.StrCmp(OldWcseguridad, WebComp_Wcseguridad_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpMPW0028"+"");
               }
               WebComp_Wcseguridad.componentdraw();
               if ( StringUtil.StrCmp(OldWcseguridad, WebComp_Wcseguridad_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspEndCmp();
               }
            }
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table12_10_012e( true) ;
         }
         else
         {
            wb_table12_10_012e( false) ;
         }
      }

      protected void wb_table13_13_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(92), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(692), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:44px;width:125px\">") ;
            /* Text block */
            ClassString = "TextBlockHeader" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockheader1_Internalname, 1, 1, 0, "Trazabilidad de Bienes de Uso", "", "", "", 0, lblTextblockheader1_Jsonclick, "E_MPAGE.", StyleString, ClassString, "HLP_MPTrazabilidad.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"width:3px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"bottom\"  style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            context.WriteHtmlText( "&nbsp;") ;
            /* Text block */
            ClassString = "SubTitle" ;
            StyleString = "color:#FFFFFF; background:#00FFFFFF" ;
            GxWebStd.gx_label_ctrl( context, lblTxtusr_Internalname, lblTxtusr_Visible, 1, 0, "Usuario:", "", "", "", 0, lblTxtusr_Jsonclick, "E_MPAGE.", StyleString, ClassString, "HLP_MPTrazabilidad.htm");
            /* Text block */
            ClassString = "SubTitle" ;
            StyleString = "color:#FFFFFF; background:#00FFFFFF" ;
            GxWebStd.gx_label_ctrl( context, lblUsuario_Internalname, lblUsuario_Visible, 1, 0, lblUsuario_Caption, "", "", "", 0, lblUsuario_Jsonclick, "E_MPAGE.", StyleString, ClassString, "HLP_MPTrazabilidad.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td valign=\"bottom\" >") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',true,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_desconectar_Internalname, "Desconectar", "Desconectar", "", StyleString, ClassString, bttBtn_desconectar_Visible, 1, "rounded", 5, bttBtn_desconectar_Jsonclick, "EDESCONECTAR_MPAGE.", TempTags, "", "", "HLP_MPTrazabilidad.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td valign=\"bottom\" >") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',true,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cambioclave_Internalname, "Cambiar Contraseña", "Cambiar Contraseña", "", StyleString, ClassString, bttBtn_cambioclave_Visible, 1, "rounded", 5, bttBtn_cambioclave_Jsonclick, "ECAMBIAR CONTRASEñA_MPAGE.", TempTags, "", "", "HLP_MPTrazabilidad.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table13_13_012e( true) ;
         }
         else
         {
            wb_table13_13_012e( false) ;
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
         PA012( ) ;
         WS012( ) ;
         WE012( ) ;
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
         AddStyleSheetFile("DropDownTabsMenu/css/DropDownTabsMenu.css", "?235400");
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         if ( StringUtil.StrCmp(WebComp_Wcseguridad_Component, "") == 0 )
         {
            WebComp_Wcseguridad = getWebComponent(GetType(), "GeneXus.Programs", "wcseguridad", new Object[] {context} );
            WebComp_Wcseguridad.ComponentInit();
            WebComp_Wcseguridad.Name = "WCSEGURIDAD";
            WebComp_Wcseguridad_Component = "WCSEGURIDAD" ;
         }
         if ( ! ( WebComp_Wcseguridad == null ) )
         {
            if ( StringUtil.Len( WebComp_Wcseguridad_Component) != 0 )
            {
               WebComp_Wcseguridad.componentthemes();
            }
         }
         if ( ! ( WebComp_Wcrecentlinks == null ) )
         {
            if ( StringUtil.Len( WebComp_Wcrecentlinks_Component) != 0 )
            {
               WebComp_Wcrecentlinks.componentthemes();
            }
         }
         idxLst = 1 ;
         while ( idxLst <= getDataAreaObject().GetForm().Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( getDataAreaObject().GetForm().Jscriptsrc.Item(idxLst)), "?19295590");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("mptrazabilidad.js", "?19295590");
         context.AddJavascriptSource("DropDownTabsMenu/dropdowntabs.js", "");
         context.AddJavascriptSource("DropDownTabsMenu/DropDownTabsMenuRender.js", "");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         imgImage2_Internalname = "IMAGE2_MPAGE" ;
         lblTextblockheader1_Internalname = "TEXTBLOCKHEADER1_MPAGE" ;
         lblTxtusr_Internalname = "TXTUSR_MPAGE" ;
         lblUsuario_Internalname = "USUARIO_MPAGE" ;
         bttBtn_desconectar_Internalname = "BTN_DESCONECTAR_MPAGE" ;
         bttBtn_cambioclave_Internalname = "BTN_CAMBIOCLAVE_MPAGE" ;
         tblTable3_Internalname = "TABLE3_MPAGE" ;
         tblTable5_Internalname = "TABLE5_MPAGE" ;
         imgImage1_Internalname = "IMAGE1_MPAGE" ;
         tblTable4_Internalname = "TABLE4_MPAGE" ;
         Dropdowntabsmenu1_Internalname = "DROPDOWNTABSMENU1_MPAGE" ;
         tblTablemenu_Internalname = "TABLEMENU_MPAGE" ;
         lblPrg_desc_Internalname = "PRG_DESC_MPAGE" ;
         tblTablecontent_Internalname = "TABLECONTENT_MPAGE" ;
         tblTable7_Internalname = "TABLE7_MPAGE" ;
         tblTable8_Internalname = "TABLE8_MPAGE" ;
         tblTable9_Internalname = "TABLE9_MPAGE" ;
         lblMensajes_Internalname = "MENSAJES_MPAGE" ;
         imgImage3_Internalname = "IMAGE3_MPAGE" ;
         tblTable1_Internalname = "TABLE1_MPAGE" ;
         tblTable10_Internalname = "TABLE10_MPAGE" ;
         lblHome_Internalname = "HOME_MPAGE" ;
         lblFirsttext_Internalname = "FIRSTTEXT_MPAGE" ;
         lblSecondtext_Internalname = "SECONDTEXT_MPAGE" ;
         lblThirdtext_Internalname = "THIRDTEXT_MPAGE" ;
         lblFourthtext_Internalname = "FOURTHTEXT_MPAGE" ;
         lblFifthtext_Internalname = "FIFTHTEXT_MPAGE" ;
         tblTable2_Internalname = "TABLE2_MPAGE" ;
         tblTable11_Internalname = "TABLE11_MPAGE" ;
         tblTable6_Internalname = "TABLE6_MPAGE" ;
         getDataAreaObject().GetForm().Internalname = "FORM_MPAGE" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         bttBtn_cambioclave_Visible = 1 ;
         bttBtn_desconectar_Visible = 1 ;
         lblUsuario_Visible = 1 ;
         lblTxtusr_Visible = 1 ;
         lblFifthtext_Visible = 1 ;
         lblFourthtext_Visible = 1 ;
         lblThirdtext_Visible = 1 ;
         lblSecondtext_Visible = 1 ;
         lblFirsttext_Visible = 1 ;
         lblHome_Jsonclick = "" ;
         tblTablecontent_Visible = 1 ;
         tblTablemenu_Visible = 1 ;
         lblMensajes_Caption = "" ;
         lblPrg_desc_Caption = "Titulo" ;
         lblUsuario_Caption = " " ;
         lblHome_Visible = 1 ;
         tblTable2_Visible = 1 ;
         WebComp_Wcseguridad_Visible = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, "gxHTMLWrpMPW0028"+"", "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(WebComp_Wcseguridad_Visible), 5, 0)));
         Dropdowntabsmenu1_Menustyle = "slidetabsmenu" ;
         Dropdowntabsmenu1_Height = "34" ;
         Dropdowntabsmenu1_Width = StringUtil.LTrim( StringUtil.Str( (decimal)(100), 3, 0)) ;
         Contentholder.setDataArea(getDataAreaObject());
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
         Contentholder = new GXDataAreaControl();
         AV12TabsMenuData = new GxObjectCollection( context, "TabsMenuData.TabsMenuDataItem", "MarianoTesis", "SdtTabsMenuData_TabsMenuDataItem", "GeneXus.Programs");
         sPrefix = "" ;
         OldWcseguridad = "" ;
         WebComp_Wcseguridad_Component = "" ;
         OldWcrecentlinks = "" ;
         WebComp_Wcrecentlinks_Component = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV5PRG_WEB = "" ;
         AV6Context = new SdtContext(context);
         AV23USUARIO = "" ;
         GXt_objcol_SdtTabsMenuData_TabsMenuDataItem2 = new GxObjectCollection( context, "TabsMenuData.TabsMenuDataItem", "MarianoTesis", "SdtTabsMenuData_TabsMenuDataItem", "GeneXus.Programs");
         AV24SISTEMA = "" ;
         scmdbuf = "" ;
         H00012_A7USU_DES = new String[] {""} ;
         H00012_A6USU_COD = new String[] {""} ;
         A7USU_DES = "" ;
         A6USU_COD = "" ;
         AV26window = new GXWindow();
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblPrg_desc_Jsonclick = "" ;
         lblFirsttext_Jsonclick = "" ;
         lblSecondtext_Jsonclick = "" ;
         lblThirdtext_Jsonclick = "" ;
         lblFourthtext_Jsonclick = "" ;
         lblFifthtext_Jsonclick = "" ;
         lblMensajes_Jsonclick = "" ;
         GXt_char1 = "" ;
         lblTextblockheader1_Jsonclick = "" ;
         lblTxtusr_Jsonclick = "" ;
         lblUsuario_Jsonclick = "" ;
         TempTags = "" ;
         bttBtn_desconectar_Jsonclick = "" ;
         bttBtn_cambioclave_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sDynURL = "" ;
         Form = new GXWebForm();
         GXt_char3 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.mptrazabilidad__default(),
            new Object[][] {
                new Object[] {
               H00012_A7USU_DES, H00012_A6USU_COD
               }
            }
         );
         WebComp_Wcseguridad = new GeneXus.Http.GXNullWebComponent();
         WebComp_Wcrecentlinks = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short initialized ;
      private short GxWebError ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short AV25cant_usu ;
      private short nGotPars ;
      private short nGXWrapped ;
      private int WebComp_Wcseguridad_Visible ;
      private int bttBtn_desconectar_Visible ;
      private int bttBtn_cambioclave_Visible ;
      private int lblTxtusr_Visible ;
      private int lblUsuario_Visible ;
      private int tblTable2_Visible ;
      private int lblHome_Visible ;
      private int lblFirsttext_Visible ;
      private int lblSecondtext_Visible ;
      private int lblThirdtext_Visible ;
      private int lblFourthtext_Visible ;
      private int lblFifthtext_Visible ;
      private int tblTablemenu_Visible ;
      private int tblTablecontent_Visible ;
      private int idxLst ;
      private String Dropdowntabsmenu1_Width ;
      private String Dropdowntabsmenu1_Height ;
      private String Dropdowntabsmenu1_Menustyle ;
      private String sPrefix ;
      private String OldWcseguridad ;
      private String WebComp_Wcseguridad_Component ;
      private String OldWcrecentlinks ;
      private String WebComp_Wcrecentlinks_Component ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String AV5PRG_WEB ;
      private String bttBtn_desconectar_Internalname ;
      private String bttBtn_cambioclave_Internalname ;
      private String lblTxtusr_Internalname ;
      private String lblUsuario_Internalname ;
      private String tblTable2_Internalname ;
      private String lblHome_Internalname ;
      private String lblFirsttext_Internalname ;
      private String lblSecondtext_Internalname ;
      private String lblThirdtext_Internalname ;
      private String lblFourthtext_Internalname ;
      private String lblFifthtext_Internalname ;
      private String lblUsuario_Caption ;
      private String lblPrg_desc_Caption ;
      private String lblPrg_desc_Internalname ;
      private String lblMensajes_Caption ;
      private String lblMensajes_Internalname ;
      private String tblTablemenu_Internalname ;
      private String tblTablecontent_Internalname ;
      private String AV23USUARIO ;
      private String AV24SISTEMA ;
      private String scmdbuf ;
      private String A7USU_DES ;
      private String A6USU_COD ;
      private String sStyleString ;
      private String tblTable6_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblPrg_desc_Jsonclick ;
      private String tblTable11_Internalname ;
      private String lblHome_Jsonclick ;
      private String lblFirsttext_Jsonclick ;
      private String lblSecondtext_Jsonclick ;
      private String lblThirdtext_Jsonclick ;
      private String lblFourthtext_Jsonclick ;
      private String lblFifthtext_Jsonclick ;
      private String tblTable10_Internalname ;
      private String tblTable1_Internalname ;
      private String lblMensajes_Jsonclick ;
      private String imgImage3_Internalname ;
      private String tblTable9_Internalname ;
      private String tblTable8_Internalname ;
      private String tblTable7_Internalname ;
      private String tblTable4_Internalname ;
      private String imgImage2_Internalname ;
      private String imgImage1_Internalname ;
      private String tblTable5_Internalname ;
      private String GXt_char1 ;
      private String tblTable3_Internalname ;
      private String lblTextblockheader1_Internalname ;
      private String lblTextblockheader1_Jsonclick ;
      private String lblTxtusr_Jsonclick ;
      private String lblUsuario_Jsonclick ;
      private String TempTags ;
      private String bttBtn_desconectar_Jsonclick ;
      private String bttBtn_cambioclave_Jsonclick ;
      private String sDynURL ;
      private String Dropdowntabsmenu1_Internalname ;
      private String GXt_char3 ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool Dropdowntabsmenu1_Visible ;
      private bool returnInSub ;
      private bool AV11IsAuthorized ;
      private GXWebComponent WebComp_Wcseguridad ;
      private GXWebComponent WebComp_Wcrecentlinks ;
      private IGxDataStore dsDefault ;
      private GXDataAreaControl Contentholder ;
      private IDataStoreProvider pr_default ;
      private String[] H00012_A7USU_DES ;
      private String[] H00012_A6USU_COD ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      [ObjectCollection(ItemType=typeof( SdtTabsMenuData_TabsMenuDataItem ))]
      private IGxCollection AV12TabsMenuData ;
      [ObjectCollection(ItemType=typeof( SdtTabsMenuData_TabsMenuDataItem ))]
      private IGxCollection GXt_objcol_SdtTabsMenuData_TabsMenuDataItem2 ;
      private GXWebForm Form ;
      private GXWindow AV26window ;
      private SdtContext AV6Context ;
   }

   public class mptrazabilidad__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00012 ;
          prmH00012 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H00012", "SELECT TOP 1 [USU_DES], [USU_COD] FROM [SEG002] WITH (NOLOCK) ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00012,1,0,false,true )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
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
