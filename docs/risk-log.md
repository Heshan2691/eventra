# Risk Log

| Risk                      | Impact                 | Mitigation                                          |
| ------------------------- | ---------------------- | --------------------------------------------------- |
| Stripe integration delays | High (blocks payments) | Start with test mode early, follow Stripe docs.     |
| API performance issues    | Medium (slow UX)       | Use indexes in PostgreSQL, monitor with Prometheus. |
| GDPR compliance oversight | High (legal issues)    | Implement consent forms, data deletion options.     |
| Scope creep               | Medium (delays MVP)    | Lock MVP scope, defer advanced features.            |
