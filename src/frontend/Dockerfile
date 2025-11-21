# Stage 1: Build React app
FROM node:20-alpine AS build
WORKDIR /app

# Install build dependencies
RUN apk add --no-cache tini

# Copy package files
COPY src/frontend/package*.json ./
RUN npm ci --only=production

# Copy source and build
COPY src/frontend/ ./
RUN npm run build

# Stage 2: Serve with Nginx
FROM nginx:1.24-alpine

# Create non-root user
RUN addgroup -g 1001 -S app && \
    adduser -u 1001 -S app -G app && \
    mkdir -p /var/cache/nginx && \
    chown -R app:app /var/cache/nginx && \
    chown -R app:app /var/log/nginx && \
    chown -R app:app /etc/nginx/conf.d

# Copy custom nginx config
COPY src/frontend/nginx.conf /etc/nginx/nginx.conf

# Copy built app
COPY --from=build /app/dist /usr/share/nginx/html

# Switch to non-root
USER app
EXPOSE 80

# Health check
HEALTHCHECK --interval=30s --timeout=3s --start-period=5s --retries=3 \
    CMD curl -f http://localhost/ || exit 1

CMD ["nginx", "-g", "daemon off;"]